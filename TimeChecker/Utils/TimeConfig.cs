using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeChecker.Utils
{
    internal class TimeConfig : Config
    { 
        private Timer updateTimer;
        private static TimeConfig _instance;

        private TimeSpan notifyTime = TimeSpan.FromMinutes(5);

        public static TimeConfig GetInstance()
        {
            if (_instance == null)
                _instance = new TimeConfig();
            return _instance;
        }

        private TimeConfig()
        {
            initApp();
            if (currentDay.DayOfYear < DateTime.Now.DayOfYear)
            {
                currentDay = DateTime.Now;
                LeftDayTime = MaxDayTime;
                LeftSessionTime = MaxSessionTime;
            }

            if (FinishSessionTime + BreakTime > DateTime.Now)
                ActionInBreakTime();
            else
                LeftSessionTime = LeftDayTime < MaxSessionTime ? LeftDayTime : MaxSessionTime;

            StartSessionTime = DateTime.Now;

            updateTimer = new Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += OnTick;
            updateTimer.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            LeftSessionTime -= TimeSpan.FromSeconds(1);
            LeftDayTime -= TimeSpan.FromSeconds(1);
            if (currentDay.DayOfYear < DateTime.Now.DayOfYear)
            {
                LeftDayTime = MaxDayTime;
                LeftSessionTime = MaxSessionTime;
            }
            correctTime();
            if (LeftSessionTime == notifyTime)
            {
                PopUpForm notifyForm = new PopUpForm($"До перерыва осталось {notifyTime.Minutes} минут");
                notifyForm.TopMost = true;
                notifyForm.Focus();
                notifyForm.ShowDialog();
            }else if (LeftSessionTime == TimeSpan.FromMinutes(1)) {
                PopUpForm notifyForm = new PopUpForm($"До перерыва осталось 1 минутa");
                notifyForm.TopMost = true;
                notifyForm.Focus();
                notifyForm.ShowDialog();
            }
                
            if (LeftSessionTime < TimeSpan.Zero)
                OnEndSessionTime();
            if (LeftDayTime < TimeSpan.Zero)
                OnEndDayTime();
        }
        
        protected void correctTime()
        {
            if (LeftSessionTime > LeftDayTime)
                LeftSessionTime = LeftDayTime;
            if (LeftDayTime > MaxDayTime)
                LeftDayTime = MaxDayTime;
            if (LeftSessionTime > MaxSessionTime)
                LeftSessionTime = MaxSessionTime;
        }

        protected void OnEndSessionTime()
        {
            FinishSessionTime = DateTime.Now;
            UtilsClass.LogOffCurrentSession();
        }

        protected void OnEndDayTime()
        {
            OnEndSessionTime();
        }

        protected void ActionInBreakTime()
        {
            if (LeftSessionTime < TimeSpan.FromMinutes(5)) 
            {
                TimeSpan restBreakTime = DateTime.Now - (FinishSessionTime + BreakTime);
                if (LeftSessionTime < TimeSpan.FromMinutes(1))
                    LeftSessionTime = TimeSpan.FromMinutes(1);
            }
        }

        private void initApp()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(appPath))
            {
                if (key == null)
                {
                    using (RegistryKey Createkey = Registry.LocalMachine.CreateSubKey(appPath, true))
                    {
                        Createkey.SetValue("CurrentDay", DateTime.Now);

                        Createkey.SetValue("MaxSessionTime", TimeSpan.FromHours(2));
                        Createkey.SetValue("MaxDayTime", TimeSpan.FromHours(4));

                        Createkey.SetValue("LeftSessionTime", TimeSpan.FromHours(2));
                        Createkey.SetValue("LeftDayTime", TimeSpan.FromHours(4));

                        Createkey.SetValue("StartSessionTime", DateTime.Now);
                        Createkey.SetValue("FinishSessionTime", DateTime.Now - TimeSpan.FromMinutes(5));

                        Createkey.SetValue("BreakTime", TimeSpan.FromMinutes(5));
                    }
                }
                appKey = Registry.LocalMachine.OpenSubKey(appPath, true);
            }
        }

        public DateTime currentDay
        {
            get { return DateTime.Parse(appKey.GetValue("CurrentDay").ToString()); }
            set { appKey.SetValue("CurrentDay", value); }
        }

        public TimeSpan MaxSessionTime
        {
            get { return TimeSpan.Parse(appKey.GetValue("MaxSessionTime").ToString()); }
            set { appKey.SetValue("MaxSessionTime", value); }
        }

        public TimeSpan MaxDayTime
        {
            get { return TimeSpan.Parse(appKey.GetValue("MaxDayTime").ToString()); }
            set { appKey.SetValue("MaxDayTime", value); }
        }

        public TimeSpan LeftSessionTime
        {
            get { return TimeSpan.Parse(appKey.GetValue("LeftSessionTime").ToString()); }
            set { appKey.SetValue("LeftSessionTime", value); }
        }

        public TimeSpan LeftDayTime
        {
            get { return TimeSpan.Parse(appKey.GetValue("LeftDayTime").ToString()); }
            set { appKey.SetValue("LeftDayTime", value); }
        }

        public DateTime StartSessionTime
        {
            get { return DateTime.Parse(appKey.GetValue("StartSessionTime").ToString()); }
            set { appKey.SetValue("StartSessionTime", value); }
        }

        public DateTime FinishSessionTime
        {
            get { return DateTime.Parse(appKey.GetValue("FinishSessionTime").ToString()); }
            set { appKey.SetValue("FinishSessionTime", value); }
        }

        public TimeSpan BreakTime
        {
            get { return TimeSpan.Parse(appKey.GetValue("BreakTime").ToString()); }
            set { appKey.SetValue("BreakTime", value); }
        }

        ~TimeConfig() { FinishSessionTime = DateTime.Now; }
    }
}
