using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.Model
{
    public class Playlist
    {
        public string Name { get; set; }

        private List<PlaylistItem> _items = new List<PlaylistItem>();
        public List<PlaylistItem> Items
        {
            get => _items;
            set => _items = value;
        }

        public bool IsActive { get; set; } = false;

        public int TotalLength
        {
            get => _items.Sum(x => x.Length);
        }

        public int Count
        {
            get => _items.Count;
        }

        public Playlist(string name = "")
        {
            Name = name;
        }

        public int Add(PlaylistItem item)
        {
            Items.Add(item);
            return Count - 1;
        }

        public int Add(string file)
        {
            PlaylistItem item = new PlaylistItem();
            AudioInfo audioInfo = AudioInfoHelper.GetAudioInfo(file);
            item.File = file;
            item.DisplayTitle = AudioInfoHelper.GetDisplayTitle(audioInfo);
            item.Length = audioInfo.Length;
            _items.Add(item);
            return Count - 1;
        }

        public void Remove(int index)
        {
            string file = _items[index].File;
            _items.RemoveAt(index);
        }

        public void Remove(PlaylistItem item)
        {
            _items.Remove(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool IsOutOfRange(int index)
        {
            return !(index >= 0 && index < _items.Count);
        }
    }
}