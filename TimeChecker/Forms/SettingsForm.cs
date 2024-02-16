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
    enum ChangeTime
    {
        ThirtySeconds,
        OneMinute,
        FiveMinutes,
        Fiveteenminutes,
        Hour
    }
    public partial class SettingsForm : Form
    {
        ChangeTime currTimeType;
        TimeConfig timeConfig;
        Timer timer;

        bool IsPassHide = true;

        Dictionary<string, ChangeTime> changeTimeData = 
            new Dictionary<string, ChangeTime>()
        {
            {"30 секунд", ChangeTime.ThirtySeconds},
            {"1 минута", ChangeTime.OneMinute},
            {"5 минут", ChangeTime.FiveMinutes},
            {"15 минут", ChangeTime.Fiveteenminutes},
            {"1 час", ChangeTime.Hour},
        };

        public SettingsForm()
        {
            InitializeComponent();
            comboBox_types.DataSource = changeTimeData.Keys.ToList();
            currTimeType = changeTimeData[comboBox_types.SelectedItem.ToString()];

            timeConfig = TimeConfig.GetInstance();

            timer = new Timer();
            timer.Interval = 300;
            timer.Tick += OnTick;
            timer.Start();
        }
        private void OnTick(object sender, EventArgs e) 
        {
            MaxDayLabel.Text = timeConfig.MaxDayTime.ToString();
            MaxSessionLabel.Text = timeConfig.MaxSessionTime.ToString();
            DayTimeLabel.Text = timeConfig.LeftDayTime.ToString();
            SessionTimeLabel.Text = timeConfig.LeftSessionTime.ToString();
        }

        private void PasswordBox_OnTouch(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            PasswordBox.PasswordChar = '*';
            PasswordBox.ForeColor = Color.Black;

            IsPassHide = true;
            PasswordBox.Enter -= PasswordBox_OnTouch;
        }

        private void PasswordBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AppConfig appConfig = AppConfig.GetInstance();

                if (PasswordBox.Text == appConfig.Password)
                {

                    MaxDayMinusBtn.Enabled = true;
                    MaxDayPlusBtn.Enabled = true;
                    MaxSessionMinusBtn.Enabled = true;
                    MaxSessionPlusBtn.Enabled = true;
                    DayPLusBtn.Enabled = true;
                    DayMinusBtn.Enabled = true;
                    SessionMinusBtn.Enabled = true;
                    SessionPlusBtn.Enabled = true;
                    comboBox_types.Enabled = true;

                    // change btns
                    PasswordBox.Visible = false;
                    HidePassBtn.Visible = false;
                    ChangePassBtn.Visible = true;
                    ChangePassBtn.Enabled = true;
                }

            }
        }

        private void HidePassBtn_Click(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = IsPassHide ? (char)0 : '*';
            HidePassBtn.BackgroundImage = IsPassHide 
                ? Properties.Resources.hide_eye 
                : Properties.Resources.open_eye;
            IsPassHide = !IsPassHide;
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm passwordForm = new ChangePasswordForm();
            passwordForm.ShowDialog();
        }

        private void MaxDayPlusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.MaxDayTime += TimeTypeAsTimeSpan(currTimeType);
        }

        private void MaxDayMinusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.MaxDayTime -= TimeTypeAsTimeSpan(currTimeType);
        }

        private void MaxSessionPlusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.MaxSessionTime += TimeTypeAsTimeSpan(currTimeType);
        }

        private void MaxSessionMinusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.MaxSessionTime -= TimeTypeAsTimeSpan(currTimeType);
        }

        private void DayPLusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.LeftDayTime += TimeTypeAsTimeSpan(currTimeType);
        }

        private void DayMinusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.LeftDayTime -= TimeTypeAsTimeSpan(currTimeType);
        }

        private void SessionPlusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.LeftSessionTime += TimeTypeAsTimeSpan(currTimeType);
        }

        private void SessionMinusBtn_Click(object sender, EventArgs e)
        {
            timeConfig.LeftSessionTime -= TimeTypeAsTimeSpan(currTimeType);
        }

        private void comboBox_OnChangeSelected(object sender, EventArgs e)
        {
            string key = comboBox_types.SelectedItem.ToString();
            currTimeType = changeTimeData[key];
        }

        private static TimeSpan TimeTypeAsTimeSpan(ChangeTime changeTime)
        {
            switch (changeTime)
            {
                case ChangeTime.ThirtySeconds:
                    return TimeSpan.FromSeconds(30);
                case ChangeTime.OneMinute:
                    return TimeSpan.FromMinutes(1);
                case ChangeTime.FiveMinutes:
                    return TimeSpan.FromMinutes(5);
                case ChangeTime.Fiveteenminutes:
                    return TimeSpan.FromMinutes(15);
                case ChangeTime.Hour:
                    return TimeSpan.FromHours(1);
                default:
                    return TimeSpan.Zero;
            }
        }
    }
}
