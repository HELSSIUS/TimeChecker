using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Documents;

namespace TimeChecker.Utils
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WTS_SESSION_INFO
    {
        public int SessionID;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pWinStationName;
        public WTS_CONNECTSTATE_CLASS State;
    }

    public enum WTS_CONNECTSTATE_CLASS
    {
        WTSActive,          // Пользователь активен
        WTSConnected,       // Пользователь подключен
        WTSConnectQuery,    // Поиск подключения
        WTSShadow,          // Сессия находится в режиме теневого управления
        WTSDisconnected,    // Пользователь отключен
        WTSIdle,            // Сессия находится в режиме ожидания
        WTSListen,          // Сессия находится в режиме прослушивания (неактивная)
        WTSReset,           // Сессия сброшена
        WTSDown,            // Сессия выключена
        WTSInit             // Сессия находится в процессе инициализации
    }

    internal class UtilsClass
    {

        const int WTS_CURRENT_SESSION = -1;

        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSQuerySessionInformation(IntPtr hServer, int sessionId, int WTSInfoClass,
            out IntPtr ppBuffer, out int pBytesReturned);

        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSEnumerateSessions(IntPtr hServer, int Reserved, int Version,
            ref IntPtr ppSessionInfo, ref int pCount);

        [DllImport("wtsapi32.dll")]
        static extern void WTSFreeMemory(IntPtr pointer);

        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSLogoffSession(IntPtr hServer, int sessionId, bool bWait);

        public static void LogOffCurrentSession()
        {
            if (!WTSLogoffSession(IntPtr.Zero, GetCurrentSessionID(), false))
            {
                int error = Marshal.GetLastWin32Error();
                Console.WriteLine($"Error: {error}");
            }
        }

        public static WTS_SESSION_INFO[] SessionsInfo()
        {
            IntPtr buffer = IntPtr.Zero;
            int count = 0;
            IntPtr WTS_CURRENT_SERVER_HANDLE = IntPtr.Zero;
            WTS_SESSION_INFO[] sessionInfo;
            if (WTSEnumerateSessions(WTS_CURRENT_SERVER_HANDLE, 0, 1, ref buffer, ref count))
            {
                sessionInfo = new WTS_SESSION_INFO[count];
                for (int i = 0; i < count; i++)
                {
                    sessionInfo[i] = (WTS_SESSION_INFO)Marshal.PtrToStructure(
                        (IntPtr)((int)buffer + (Marshal.SizeOf(new WTS_SESSION_INFO()) * i)),
                        typeof(WTS_SESSION_INFO)
                    );
                }
            }
            else
            {
                sessionInfo = new WTS_SESSION_INFO[0];
            }
            WTSFreeMemory(buffer);
            return sessionInfo;
        }

        public static int GetCurrentSessionID()
        {
            return Process.GetCurrentProcess().SessionId;
        }

        public static WTS_SESSION_INFO? GetCurrentSessionInfo()
        {
            WTS_SESSION_INFO[] sessions = SessionsInfo();
            for (int i = 0; i < sessions.Length; i++)
            {
                if (sessions[i].SessionID == GetCurrentSessionID())
                {
                    return sessions[i];
                }
            }
            return null;
        }

        public static void addToAutoRun()
        {
            string runPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            using (RegistryKey runKey = Registry.LocalMachine.OpenSubKey(runPath, true))
            {
                if (runKey.GetValue(Config.appName) != null)
                {
                    string appPath = (string)runKey.GetValue(Config.appName);
                    if (appPath != Application.ExecutablePath)
                        runKey.SetValue(Config.appName, Application.ExecutablePath);
                } else
                    runKey.SetValue(Config.appName, Application.ExecutablePath);
            }
        }
    }
}
