using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeChecker.Forms;
using TimeChecker.Utils;

namespace TimeChecker
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                UtilsClass.addToAutoRun();
            }catch (Exception e)
            {;
                PopUpForm popUpForm = new PopUpForm($"Не получилось добавить {Config.appName} в автозапуск");
                popUpForm.ShowDialog();
            }
            // start app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimeWidget());
        }
    }
}
