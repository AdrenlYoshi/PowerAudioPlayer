using Newtonsoft.Json;
using PowerAudioPlayer.Model;
using System.IO;
using System.Text;

namespace PowerAudioPlayer.Controllers.Helper
{
    internal static class PlaylistHelper
    {
        public static readonly string DefaultPlaylistDir = Path.Combine(Utils.GetProgramLocalAppDataPath(), "Playlist") ;

        public static List<Playlist> _playlists = new List<Playlist>();
        public static List<Playlist> Playlists
        {
            get => _playlists;
            set => _playlists = value;
        }

        public static int Count
        {
            get => _playlists.Count;
        }

        public static int ActivePlaylistIndex
        {
            get => _playlists.FindIndex(x => x.IsActive == true);
        }

        public static Playlist ActivePlaylist
        {
            get => _playlists[ActivePlaylistIndex];
            set => _playlists[ActivePlaylistIndex] = value;
        }

        public static void LoadPlaylists()
        {
            var cmd = Environment.GetCommandLineArgs();
            cmd[0] = string.Empty;
            Directory.CreateDirectory(DefaultPlaylistDir);
            IEnumerable<string> files = Utils.SearchFiles(DefaultPlaylistDir, ["*.json"], false);
            foreach (string file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                int lastIndex = LoadPlaylist(file);
                if (name == "active")
                {
                    Playlists[lastIndex].IsActive = true;
                    Playlists[lastIndex].Name = Player.GetString("ActivePlaylist");
                    if (cmd.Length > 1)
                    {
                        Playlists[lastIndex].Items.Clear();
                        foreach (var f in cmd)
                        {
                            if(!string.IsNullOrEmpty(f))
                            Playlists[lastIndex].Items.Add(PlaylistItem.FormFile(f));
                        }
                    }
                }
            }
            if (_playlists.Count == 0 || _playlists.FindLast(x => x.IsActive == true) == null)
            {
                _playlists.Add(new Playlist() { Name = Player.GetString("ActivePlaylist"), IsActive = true });
            }
        }

        public static void SavePlaylists()
        {
            Directory.CreateDirectory(DefaultPlaylistDir);
            for (int i = 0; i < _playlists.Count; i++)
            {
                if (Playlists[i].IsActive)
                    SavePlaylist(DefaultPlaylistDir + "\\active.json", i);
                else
                    SavePlaylist(DefaultPlaylistDir + "\\" + Playlists[i].Name + ".json", i);
            }
        }

        public static int LoadPlaylist(string file)
        {
            using StreamReader sr = new StreamReader(file);
            string? strLine = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            while ((strLine = sr.ReadLine()) != null)
                stringBuilder.AppendLine(strLine);
            Playlist pl = new Playlist();
            try
            {
                pl.Items = JsonConvert.DeserializeObject<List<PlaylistItem>>(stringBuilder.ToString()) ?? new List<PlaylistItem>();
            }
            catch
            {
                pl.Items = new List<PlaylistItem>();
            }
            pl.Name = Path.GetFileNameWithoutExtension(file);
            if (NameExists(pl.Name))
                pl.Name += _playlists.Count(f => f.Name.Equals(pl.Name)).ToString();
            _playlists.Add(pl);
            return _playlists.Count - 1;
        }

        public static void ReplacePlaylist(string file, int index = 0)
        {
            using StreamReader sr = new StreamReader(file);
            string? strLine = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            while ((strLine = sr.ReadLine()) != null)
                stringBuilder.AppendLine(strLine);
            try
            {
                _playlists[index].Items = JsonConvert.DeserializeObject<List<PlaylistItem>>(stringBuilder.ToString()) ?? new List<PlaylistItem>();
            }
            catch
            {
                return;
            }
        }

        public static void SavePlaylist(string file, int index = 0)
        {
            using StreamWriter streamWriter = new StreamWriter(file, false);
            streamWriter.Write(JsonConvert.SerializeObject(Playlists[index].Items));
        }

        public static bool FileExistsInAnyList(string file)
        {
            foreach (var list in Playlists)
            {
                if (list.Items.Exists(o => o.File.Equals(file)))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsOutOfRange(int index)
        {
            return !(index >= 0 && index < _playlists.Count);
        }

        public static bool CheckName(string name)
        {
            if (!NameExists(name) && !name.Equals("active", StringComparison.CurrentCultureIgnoreCase) && name.IndexOfAny(Path.GetInvalidFileNameChars()) == -1)
                return true;
            else
                return false;
        }

        public static bool Rename(string newName, int index = 0)
        {
            if (CheckName(newName) && index != 0)
            {
                try
                {
                    File.Move(Path.Combine(DefaultPlaylistDir, $"{_playlists[index].Name}.json"), Path.Combine(DefaultPlaylistDir, $"{newName}.json"));
                    _playlists[index].Name = newName;
                    return true;
                }
                catch
                {
                    _playlists[index].Name = newName;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static int Add(Playlist list)
        {
            if (CheckName(list.Name))
            {
                _playlists.Add(list);
                try
                {
                    File.WriteAllText(Path.Combine(DefaultPlaylistDir, $"{list.Name}.json"), string.Empty);
                    return _playlists.Count - 1;
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public static bool Remove(Playlist list)
        {
            try
            {
                _playlists.Remove(list);
                File.Delete(Path.Combine(DefaultPlaylistDir, $"{list.Name}.json"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Remove(int index)
        {
            if (index != 0)
            {
                return Remove(_playlists[index]);
            }
            else
            {
                return false;
            }
        }

        public static bool NameExists(string Name)
        {
            if (_playlists.Exists(o => o.Name == Name))
                return true;
            else
                return false;
        }

        public static void CopyToActivePlaylist(int from)
        {
            if (from == 0 || Playlists[from].Items.SequenceEqual(ActivePlaylist.Items))
                return;
            ActivePlaylist.Items = _playlists[from].Items;
        }

        public static void CopyToActivePlaylist(List<PlaylistItem> fromitems)
        {
            if (fromitems.SequenceEqual(ActivePlaylist.Items))
                return;
            ActivePlaylist.Items = fromitems;
        }

        public static void CopyToPlaylist(int from, int to)
        {
            if (Playlists[from].Items.SequenceEqual(Playlists[to].Items))
                return;
            _playlists[to].Items = _playlists[from].Items;
        }

        public static void CopyToPlaylist(List<PlaylistItem> fromitems, int to)
        {
            if (fromitems.SequenceEqual(Playlists[to].Items))
                return;
            _playlists[to].Items = fromitems;
        }
    }
}