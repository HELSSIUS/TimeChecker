using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeChecker.Utils
{
    abstract class Config
    {
        public const string appName = "TimeChecker"; 

        protected const string appPath = @"SOFTWARE\" + appName;
        protected RegistryKey appKey;
    }
}
