using PowerAudioPlayer.Controllers.Helper;
using PowerAudioPlayer.Controllers.PlayerCore;
using System.IO;

namespace PowerAudioPlayer.Controllers
{
    public enum PlayMode
    {
        OrderPlay,
        PlaylistLoop,
        TrackLoop,
        ShufflePlay
    }

    public enum PlayerCores
    {
        BASS,
        MCI
    }

    public enum ABRepeatMode
    {
        None,
        ASelected,
        ABRepeat
    };

    public class FileSearchArgs
    {
        public string Directory { get; set; } = string.Empty;

        public bool SearchSubDir { get; set; } = true;

        public FileSearchArgs(string dir, bool searchSubDir) { Directory = dir; SearchSubDir = searchSubDir; }
    }

    public class MediaLibraryDirectory
    {
        public string Directory { get; set; } = string.Empty;


        public MediaLibraryDirectory(string dir) { Directory = dir; }

        public MediaLibraryDirectory() { }
    }

    internal class Player
    {
        public const int WM_USER = 0x400;
        public const int WM_PLAY = WM_USER + 2;
        public const int WM_REFRESHPLAYLISTVIEW = WM_USER + 3;
        public const int WM_LOCATETO = WM_USER + 4;
        public const int WM_SETHOTKEY = WM_USER + 5;
        public const int WM_LOADLYRICS = WM_USER + 6;
        public const int WM_LRCROLL = WM_USER + 7;
        public const int WM_CLEARLRC = WM_USER + 8;
        public const int WM_REFRESHMEDIALIBRARY = WM_USER + 10;
        public const int WM_HANDLECOMMANDLINE = WM_USER + 11;
        public const int WM_REFRESHHISTORYVIEW = WM_USER + 12;
        public const int WM_SWITCHPLAYLISTEDITORFORMEMBEDDED = WM_USER + 13;

        public static ABRepeatMode abRepeatMode = ABRepeatMode.None;
        public static int playIndex = -1;
        private static int aRepeatPos = 0;
        private static int bRepeatPos = 0;

        public static IPlayerCore Core;
        public static void Init()
        {
            if(!Path.Exists(Utils.GetProgramLocalAppDataPath()))
                Directory.CreateDirectory(Utils.GetProgramLocalAppDataPath());
            if(Settings.Default.Equalizer == null || Settings.Default.Equalizer.Length == 0) 
                Settings.Default.Equalizer = new int[10];
            if (Settings.Default.MediaLibraryDirectories == null)
                Settings.Default.MediaLibraryDirectories = new List<MediaLibraryDirectory>();
            try
            {
                if (Settings.Default.PlayerCore == PlayerCores.MCI)
                    Core = new MCICore();
                else
                    Core = new BASSCore();
            }
            catch 
            { 
                Core = new BASSCore(); 
            }
            Core.Init();
            Core.SetMIDISoundFont(Settings.Default.MIDISoundFont);
            Core.SetConfig(PlayerCoreConfig.PlayBuffer, Settings.Default.PlayBuffer);
            Core.SetConfig(PlayerCoreConfig.NetBuffer, Settings.Default.NetBuffer);
            Core.SetConfig(PlayerCoreConfig.NetTimeOut, Settings.Default.NetTimeOut);
            Core.SetConfig(PlayerCoreConfig.MIDIVoices, Settings.Default.MIDIVoices);
            MediaLibraryHelper.LoadMediaLibrary();
            PlaylistHelper.LoadPlaylists();
            PlayHistoryHelper.LoadHistory();
        }

        public static void SaveDataFile()
        {
            MediaLibraryHelper.SaveMediaLibrary();
            PlayHistoryHelper.SaveHistory();
            PlaylistHelper.SavePlaylists();
            Settings.Default.Save();
        }

        public static void UnInit()
        {
            Core.UnInit();
            SaveDataFile();
        }

        public static string GetString(string id, params object?[] args)
        {
            if(Utils.IsDesignMode())
                return id;
            if (args.Length == 0)
            {
                try
                {
                    return Program.languageResourceManager.GetString(id);
                }
                catch 
                {
#if DEBUG
                    return $"[!{id}:{Thread.CurrentThread.CurrentUICulture.Name}!]";
#else    
                    return Program.languageResourceManager.GetString(id, Program.defaultCultureInfo);
#endif
                }
            }
            else
            {
                try
                {
                    string str = Program.languageResourceManager.GetString(id);
                    return string.Format(str, args);
                }
                catch
                {   
#if DEBUG
                    return $"[!{id}:{Thread.CurrentThread.CurrentUICulture.Name}!]";
#else    
                    return Program.languageResourceManager.GetString(id, Program.defaultCultureInfo);
#endif
                }
            }
        }

        public static bool SetARepeatPoint()
        {
            aRepeatPos = Core.GetPositionMillisecond();
            abRepeatMode = ABRepeatMode.ASelected;
            return true;
        }

        public static bool SetBRepeatPoint()
        {
            if (abRepeatMode != ABRepeatMode.None)
            {
                long timeSpan = Core.GetPositionMillisecond() - aRepeatPos;
                if (timeSpan > 200 && timeSpan < Core.GetLengthMillisecond())
                {
                    bRepeatPos = Core.GetPositionMillisecond();
                    abRepeatMode = ABRepeatMode.ABRepeat;
                    return true;
                }
            }
            return false;
        }

        public static bool ContinueABRepeat()
        {
            if(abRepeatMode == ABRepeatMode.ABRepeat)
            {
                if(Core.GetPositionMillisecond() > bRepeatPos || Core.GetPositionMillisecond() < aRepeatPos - 2000)
                    Core.SetPositionMillisecond(aRepeatPos);
                return true;
            }
            return false;
        }

        public static void DoABRepeat()
        {
            switch (abRepeatMode)
            {
                case ABRepeatMode.None:
                    SetARepeatPoint();
                    break;
                case ABRepeatMode.ASelected:
                    if (!SetBRepeatPoint())
                        ResetABRepeat();
                    break;
                case ABRepeatMode.ABRepeat:
                    ResetABRepeat();
                    break;
                default:
                    break;
            }
        }

        public static void ResetABRepeat()
        {
            abRepeatMode = ABRepeatMode.None;
        }

        public static Color GetThemeColor()
        {
            return Settings.Default.ThemeColorFollowingSystem ? Utils.GetSystemThemeColor() : Settings.Default.ThemeColor;
        }
    }
}