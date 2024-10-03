using MemoryPack;
using PowerAudioPlayer.Model;
using System.IO;

namespace PowerAudioPlayer.Controllers.Helper
{
    internal class MediaLibraryHelper
    {
        private static Dictionary<string, AudioInfo> _library = new Dictionary<string, AudioInfo>();
        public static string defaultFile = Path.Combine(Utils.GetProgramLocalAppDataPath(), "MediaLibrary.dat");

        public static int Count
        {
            get => _library.Count;
        }

        public static Dictionary<string, AudioInfo> Library
        {
            get => _library;
            set => _library = value;
        }

        public static int TotalLength
        {
            get => _library.Values.Where(x => x.Length > 0).ToList().Sum(x => x.Length);
        }

        public static long Size
        {
            get => Utils.GetFileSize(defaultFile);
        }

        public static void SaveMediaLibrary(string file = "")
        {
            if (string.IsNullOrEmpty(file))
                file = defaultFile;
            FileStream fs = new FileStream(file, FileMode.Create);
            fs.Write(MemoryPackSerializer.Serialize(_library));
            fs.Close();
        }

        public static void LoadMediaLibrary(string file = "")
        {
            if (string.IsNullOrEmpty(file))
                file = defaultFile;
            FileStream fs = new FileStream(file, FileMode.OpenOrCreate);
            int length = (int)fs.Length;
            byte[] buffer = new byte[length];
            fs.Read(buffer, 0, length);
            try
            {
                _library = MemoryPackSerializer.Deserialize<Dictionary<string, AudioInfo>>(buffer) ?? [];
            }
            catch
            {
                _library = new Dictionary<string, AudioInfo>();
            }
            fs.Close();
        }

        public static void ClearMediaLibrary()
        {
            _library.Clear();
        }

        public static int CleanUpMediaLibrary()
        {
            int removeCount = 0;
            foreach (KeyValuePair<string, AudioInfo> keyValuePair in _library)
            {
                if (!File.Exists(keyValuePair.Key) || !IsInMediaLibraryDirectories(keyValuePair.Key))
                {
                    Remove(keyValuePair.Key);
                    removeCount++;
                }
            }
            return removeCount;
        }

        public static bool IsInMediaLibraryDirectories(string file)
        {
            foreach(var d in Settings.Default.MediaLibraryDirectories)
            {
                string path = Path.GetDirectoryName(file);
                if(d.IncludeSubDir)
                {
                    if (Utils.IsSubDirectoryOf(path, d.Directory))
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (file.Equals(file))
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public static bool Add(string file, AudioInfo audioInfo)
        {
            try
            {
                _library.Add(file, audioInfo);
                return true;
            }
            catch
            {
                return false;
            }
        }        
        
        public static bool Add(string file)
        {
            try
            {
                _library.Add(file, AudioInfoHelper.GetAudioInfo(file));
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public static bool Remove(string file)
        {
            return _library.Remove(file);
        }

        public static void UpdateMediaLibrary()
        {
            foreach (MediaLibraryDirectory dir in Settings.Default.MediaLibraryDirectories)
            {
                var files = Utils.SearchFiles(dir.Directory, Player.Core.GetAllSupportedFileArray(), dir.IncludeSubDir);
                foreach (var file in files)
                {
                    Add(file);
                }
            }
            if (Settings.Default.MediaLibraryAutoRemove)
                CleanUpMediaLibrary();
        }

        public static string[] GetKeyWordList(ViewType type)
        {
            string[] list = [];
            switch (type)
            {
                case ViewType.Artist:
                    list = _library.Values.ToArray().Select(x => Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(x.Tag.Artist)).Distinct().ToArray();
                    break;
                case ViewType.Album:
                    list = _library.Values.ToArray().Select(x => x.Tag.Album).Distinct().ToArray();
                    break;
                case ViewType.Genre:
                    list = _library.Values.ToArray().Select(x => x.Tag.Genre).Distinct().ToArray();
                    break;
                case ViewType.FileType:
                    list = _library.Values.ToArray().Select(x => Path.GetExtension(x.File).ToLower()).Distinct().ToArray();
                    break;
                case ViewType.Folder:
                    list = _library.Values.ToArray().Select(x => Path.GetDirectoryName(x.File)).Distinct().ToArray();
                    break;
            }
            return list;
        }        
        
        public static Dictionary<string, AudioInfo> GetView(ViewType type, string keyWord)
        {
            Dictionary<string, AudioInfo> dic = new Dictionary<string, AudioInfo>();
            switch (type)
            {
                case ViewType.Artist:
                    dic = _library.Where(x => x.Value.Tag.Artist.Equals(keyWord, StringComparison.OrdinalIgnoreCase)).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case ViewType.Album:
                    dic = _library.Where(x => x.Value.Tag.Album.Equals(keyWord)).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case ViewType.Genre:
                    dic = _library.Where(x => x.Value.Tag.Genre.Equals(keyWord)).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case ViewType.FileType:
                    dic = _library.Where(x => Path.GetExtension(x.Value.File).Equals(keyWord)).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case ViewType.Folder:
                    dic = _library.Where(x => Path.GetDirectoryName(x.Value.File).Equals(keyWord, StringComparison.OrdinalIgnoreCase)).ToDictionary(x => x.Key, x => x.Value);
                    break;
            }
            return dic;
        }
    }
}