using MemoryPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerAudioPlayer.Model
{

    [Serializable]
    [MemoryPackable]
    public partial class PlayHistoryItem
    {
        public DateTime LastPlaybackTime { get; set; } = DateTime.Now;

        public int PlayCount { get; set; } = 1;

        public string DisplayTitle { get; set; } = string.Empty;

        public int Length { get; set; } = 0;

        public string File { get; set; } = string.Empty;

        [MemoryPackConstructor]
        public PlayHistoryItem() { }

        public PlayHistoryItem(DateTime lastPlaybackTime, int playCount, string displayTitle, int length, string file)
        {
            LastPlaybackTime = lastPlaybackTime;
            PlayCount = playCount;
            DisplayTitle = displayTitle;
            Length = length;
            File = file;
        }

        public PlayHistoryItem(DateTime lastPlaybackTime, int playCount, PlaylistItem item)
        {
            LastPlaybackTime = lastPlaybackTime;
            PlayCount = playCount;
            DisplayTitle = item.DisplayTitle;
            Length = item.Length;
            File = item.File;
        }
    }
}
