using System.Runtime.InteropServices;
using System.Text;

namespace PowerAudioPlayer.Controllers
{
    internal class NativeAPI
    {
        public const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        public const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
        public const int DWMWA_SYSTEMBACKDROP_TYPE = 38;
        public const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;
        public const int DWMWA_COLOR_DEFAULT = -1;
        public const int DWMWA_COLOR_NONE = -2;
        public const int GWL_STYLE = -16;
        public const int HTCAPTION = 2;
        public const int WM_CREATE = 0x1;
        public const int WM_DESTROY = 0x2;
        public const int MF_SEPARATOR = 0x800;
        public const int MF_STRING = 0x0;
        public const int SB_HORZ = 0;
        public const uint SEE_MASK_INVOKEIDLIST = 12;
        public const int SW_SHOW = 5;
        public const int VM_NCLBUTTONDOWN = 0XA1;
        public const int WM_HOTKEY = 0x312;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int WM_GETMINMAXINFO = 0x0024;
        public const int WM_APPCOMMAND = 0x319;
        public const int WM_COPYDATA = 0x004A;

        public const int APPCOMMAND_VOLUME_DOWN = 9;
        public const int APPCOMMAND_VOLUME_UP = 10;
        public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;
        public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;
        public const int APPCOMMAND_MEDIA_STOP = 13;
        public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;
        public const int APPCOMMAND_MEDIA_PLAY = 46;
        public const int APPCOMMAND_MEDIA_PAUSE = 47;
        public const int APPCOMMAND_MEDIA_CHANNEL_UP = 51;
        public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 52;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }

        [Flags]
        public enum KeyModifiers 
        { 
            None = 0, 
            Alt = 1, 
            Ctrl = 2, 
            Shift = 4, 
            WindowsKey = 8 
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        [DllImport("shell32.dll")]
        public static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

        [DllImport("shell32.dll", ExactSpelling = true)]
        public static extern void ILFree(IntPtr pidl);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern IntPtr ILCreateFromPath(string pszPath);

        [DllImport("shell32.dll", ExactSpelling = true)]
        public static extern int SHOpenFolderAndSelectItems(IntPtr pidlList, uint cild, IntPtr children, uint dwFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, ref COPYDATASTRUCT lParam);

        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(uint uAction, uint uParam, StringBuilder lpvParam, uint init);

        [DllImport("User32.dll")]
        public static extern bool ShowWindowAsync(nint hWnd, int cmdShow);

        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(nint hWnd);

        [DllImport("uxtheme.dll")]
        public static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
        public static extern ulong mciSendString(string command, string? buffer, int bufferSize, IntPtr callback);

        [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
        public static extern bool mciExecute(string command);

        [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
        public static extern ulong mciSendCommand(uint deviceId, uint uMsg, IntPtr fdwCommand, IntPtr dwParam);
    }
}