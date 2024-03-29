﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeChecker.Forms;
using TimeChecker.Utils;

namespace TimeChecker
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, Config.appName);

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {

                try
                {
                    UtilsClass.addToAutoRun(Config.appName, Application.ExecutablePath.ToString());
                }
                catch (Exception e)
                {
                    PopUpForm popUpForm = new PopUpForm($"Не получилось добавить {Config.appName} в автозапуск");
                    popUpForm.ShowDialog();
                }
                // start app
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TimeWidget());

                mutex.ReleaseMutex();

            }


        }
    }
}
