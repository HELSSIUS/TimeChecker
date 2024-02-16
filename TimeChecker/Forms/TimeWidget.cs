using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeChecker.Forms;
using TimeChecker.Utils;

namespace TimeChecker
{
    public partial class TimeWidget : Form
    {
        bool mouseDown;
        private Point offset;

        private Timer updateTimer;
        TimeConfig timeConfig;

        public TimeWidget()
        {
            InitializeComponent();
            Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height
            );

            timeConfig = TimeConfig.GetInstance();

            DayTimeLabel.Text = timeConfig.MaxDayTime.ToString();
            SessionTimeLabel.Text = timeConfig.MaxSessionTime.ToString();

            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if ( mouseDown )
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DayTimeLabel.Text = timeConfig.LeftDayTime.ToString();
            SessionTimeLabel.Text = timeConfig.LeftSessionTime.ToString();
        }

        private void TimeLabel_OnDoubleClick(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
