using MemoryPack;
using PowerAudioPlayer.Controllers.Helper;
using System.IO;

namespace PowerAudioPlayer.Model
{
    [Serializable]
    [MemoryPackable]
    public partial class PlaylistItem
    {
        public string File { get; set; } = string.Empty;

        public string DisplayTitle { get; set; } = string.Empty;

        public int Length { get; set; } = 0;

        [MemoryPackConstructor]
        public PlaylistItem() { }

        public PlaylistItem(string file = "", string title = "", int length = 0)
        {
            File = file;
            DisplayTitle = string.IsNullOrEmpty(title) ? Path.GetFileName(file) : title;
            Length = length;
        }

        public static PlaylistItem FormFile(string file)
        {
            PlaylistItem item = new PlaylistItem();
            AudioInfo audioInfo = AudioInfoHelper.GetAudioInfo(file);
            item.File = file;
            item.DisplayTitle = AudioInfoHelper.GetDisplayTitle(audioInfo);
            item.Length = audioInfo.Length;
            return item;
        }

        public override string ToString()
        {
            return DisplayTitle;
        }
    }
}
