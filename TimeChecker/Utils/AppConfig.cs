using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Utils
{
    internal class AppConfig : Config
    {
        private const string userAppPath = appPath + @"\user";
        private RegistryKey appKey;

        private static AppConfig _instance;
        public static AppConfig GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppConfig();
            }
            return _instance;
        }

        private AppConfig()
        {
            TimeConfig timeConfig = TimeConfig.GetInstance();
            initApp();
        }

        private void initApp()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(userAppPath))
            {
                if (key == null)
                {
                    using (RegistryKey createKey = Registry.LocalMachine.CreateSubKey(userAppPath, true))
                    {
                        createKey.SetValue("password", "admin");
                    }
                }
                appKey = Registry.LocalMachine.OpenSubKey(userAppPath, true);
            }
        }

        public string Password
        {
            get { return appKey.GetValue("password").ToString(); }
            set { appKey.SetValue("password", value); }
        }
    }
}
