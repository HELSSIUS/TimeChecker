using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeChecker.Utils;

namespace TimeChecker.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordBox_OnTouch(object sender, EventArgs e)
        {
            PasswordBox.Text = string.Empty;
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.Enter -= PasswordBox_OnTouch;
        }

        private void RepeatBox_OnTouch(object sender, EventArgs e)
        {
            RepeatBox.Text = string.Empty;
            RepeatBox.ForeColor = Color.Black;
            RepeatBox.Enter -= RepeatBox_OnTouch;
        }

        private void PasswordBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RepeatBox.Focus();
        }

        private void RepeatBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && PasswordBox.Text == RepeatBox.Text)
            {
                AppConfig appConfig = AppConfig.GetInstance();
                appConfig.Password = RepeatBox.Text;
                this.Close();
            }
        }
    }
}
