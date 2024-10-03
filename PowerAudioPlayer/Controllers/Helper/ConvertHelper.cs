using PowerAudioPlayer.Model;

namespace PowerAudioPlayer.Controllers.Helper
{
    public static class ConvertHelper
    {
        public static List<PlaylistItem> ConvertPlayHistoryItemListToPlaylistItemList(List<PlayHistoryItem> i)
        {
            return i.Select(x => new PlaylistItem(x.File, x.DisplayTitle, x.Length)).ToList();
        }

        public static PlaylistItem ConvertPlayHistoryItemToPlaylistItem(PlayHistoryItem x)
        {
            return new PlaylistItem(x.File, x.DisplayTitle, x.Length);
        }

        public static List<PlaylistItem> ConvertMediaLibraryItemListToPlaylistItemList(Dictionary<string, AudioInfo> i)
        {
            return i.Values.Select(x => new PlaylistItem(x.File, AudioInfoHelper.GetDisplayTitle(x), x.Length)).ToList();
        }

        public static List<PlaylistItem> ConvertAudioInfoListToPlaylistItemList(List<AudioInfo> i)
        {
            return i.Select(x => new PlaylistItem(x.File, AudioInfoHelper.GetDisplayTitle(x), x.Length)).ToList();
        }
    }
}
