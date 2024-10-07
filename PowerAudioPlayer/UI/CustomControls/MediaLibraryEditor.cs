using BrightIdeasSoftware;
using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Model;
using System.IO;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Windows.Input;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.UI.CustomControls
{
    public partial class MediaLibraryEditor : UserControl
    {
        private bool _allMode = true;
        private List<StringArrayItem> keyWorks = new List<StringArrayItem>();
        private ViewType view = ViewType.Artist;
        private Dictionary<string, AudioInfo> result = new Dictionary<string, AudioInfo>();
        private readonly OLVColumn olvColumn = new OLVColumn("", "Value");
        private readonly OLVColumn olvColumn1 = new OLVColumn(Player.GetString("Artist"), "Tag.Artist") { Width = 100, MinimumWidth = 20, Name = "Artist" };
        private readonly OLVColumn olvColumn2 = new OLVColumn(Player.GetString("Album"), "Tag.Album") { Width = 100, MinimumWidth = 20, Name = "Album" };
        private readonly OLVColumn olvColumn3 = new OLVColumn(Player.GetString("Title"), "Tag.Title") { Width = 250, MinimumWidth = 20, Name = "Title", AspectGetter = delegate (object rowObject) { AudioInfo info = (AudioInfo)rowObject; return string.IsNullOrEmpty(info.Tag.Title) ? Path.GetFileName(info.File) : info.Tag.Title; } };
        private readonly OLVColumn olvColumn4 = new OLVColumn(Player.GetString("Genre"), "Tag.Genre") { Width = 90, MinimumWidth = 20, Name = "Genre" };
        private readonly OLVColumn olvColumn5 = new OLVColumn(Player.GetString("Length"), "Length") { Width = 70, MinimumWidth = 10, Name = "Length", AspectGetter = delegate (object rowObject) { return Utils.FormatTimeSecond(((AudioInfo)rowObject).Length); } };
        private readonly OLVColumn olvColumn6 = new OLVColumn(Player.GetString("Track"), "Tag.Track") { Width = 70, MinimumWidth = 10, Name = "Track" };
        private readonly OLVColumn olvColumn7 = new OLVColumn(Player.GetString("Disc"), "Tag.Disc") { Width = 70, MinimumWidth = 10, Name = "Disc" };
        private readonly OLVColumn olvColumn8 = new OLVColumn(Player.GetString("Year"), "Tag.Year") { Width = 70, MinimumWidth = 10, Name = "Year" };
        private readonly OLVColumn olvColumn9 = new OLVColumn(Player.GetString("Copyright"), "Tag.Copyright") { Width = 150, MinimumWidth = 20, Name = "Comment" };
        private readonly OLVColumn olvColumn10 = new OLVColumn(Player.GetString("Comment"), "Tag.Comment") { Width = 150, MinimumWidth = 20, Name = "Copyright" };

        public event EventHandler? PlayItem;
        public event EventHandler? LineUpItem;
        public event EventHandler? PlayKeyWord;
        public event EventHandler? LineUpKeyWord;
        public event EventHandler? SendToNewPlaylistKeyWord;
        public event EventHandler? SendToNewPlaylistItem;

        public Dictionary<string, AudioInfo> Result { get => result; }

        [Browsable(false)]
        public bool AllMode { get => _allMode; }

        [Browsable(false)]
        public IList<AudioInfo> SelectedItems { get => lvResult.SelectedObjects.Cast<AudioInfo>().ToList(); }

        [Browsable(false)]
        public AudioInfo SelectedItem { get => (AudioInfo)lvResult.SelectedObject; }

        public MediaLibraryEditor()
        {
            InitializeComponent();
            lvKeyWord.Columns.AddRange([olvColumn]);
            lvResult.Columns.AddRange([olvColumn1, olvColumn2, olvColumn3, olvColumn4, olvColumn5, olvColumn6, olvColumn7, olvColumn8, olvColumn9, olvColumn10]);
        }

        public void SetMode(bool allMode, ViewType type = ViewType.Artist)
        {
            _allMode = allMode;
            lvKeyWord.AdditionalFilter = null;
            lvResult.AdditionalFilter = null;
            sbFilterKey.Text = string.Empty;
            sbFilterResult.Text = string.Empty;
            if (allMode)
            {
                splitContainer1.Panel1Collapsed = true;
                result.Clear();
                keyWorks.Clear();
                lvResult.ClearObjects();
                lvResult.SetObjects(MediaLibraryHelper.Library.Values);
                UpdateStatusBar();
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                view = type;
                result.Clear();
                keyWorks.Clear();
                lvResult.ClearObjects();
                keyWorks = MediaLibraryHelper.GetKeyWordList(type).Select(x => new StringArrayItem(x)).ToList();
                lvKeyWord.SetObjects(keyWorks);
                lvKeyWord.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                UpdateStatusBar();
            }

        }

        private void UpdateStatusBar()
        {
            if (AllMode)
            {
                lblTotalCount.Text = MediaLibraryHelper.Count.ToString();
                lblTotalLength.Text = Utils.FormatTimeSecond(MediaLibraryHelper.TotalLength);
            }
            else
            {
                lblTotalCount.Text = result.Count.ToString();
                lblTotalLength.Text = Utils.FormatTimeSecond(result.Values.Sum(x => x.Length));
            }
        }

        private void lvKeyWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKeyWord.SelectedIndex != -1)
            {
                lvResult.ClearObjects();
                result = MediaLibraryHelper.GetView(view, lvKeyWord.Items[lvKeyWord.SelectedIndex].Text);
                lvResult.SetObjects(result.Values);
            }
            UpdateStatusBar();
        }

        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedIndex != -1)
                PlayItem?.Invoke(sender, e);
        }

        private void tsmiPlayKeyWord_Click(object sender, EventArgs e)
        {
            if (lvKeyWord.SelectedIndex != -1)
                PlayKeyWord?.Invoke(sender, e);
        }

        private void tsmiluKeyWord_Click(object sender, EventArgs e)
        {
            if (lvKeyWord.SelectedIndex != -1)
                LineUpKeyWord?.Invoke(sender, e);
        }

        private void cmsKeyWord_Opening(object sender, CancelEventArgs e)
        {
            tsmiKeyWordSendToPlaylist.DropDownItems.Clear();
            for (int i = 0; i < PlaylistHelper.Count; i++)
            {
                if (PlaylistHelper.Playlists[i].IsActive)
                    continue;
                ToolStripItem tsitem = new ToolStripMenuItem(PlaylistHelper.Playlists[i].Name);
                tsitem.Tag = i;
                tsitem.Click += (object? sender, EventArgs e) => { PlaylistHelper.Playlists[Convert.ToInt32(((ToolStripMenuItem)sender).Tag)].Items.AddRange(ConvertHelper.ConvertMediaLibraryItemListToPlaylistItemList(result)); };
                tsmiKeyWordSendToPlaylist.DropDownItems.Add(tsitem);
            }
        }

        private void tsmiKeyWordSendToNewPlaylist_Click(object sender, EventArgs e)
        {
            if (result.Count != 0)
            {
                string name = Interaction.InputBox(Player.GetString("MsgAddPlaylist"), Player.GetString("ProgramName"));
                if (name != "")
                {
                    if (PlaylistHelper.Add(new Playlist(name) { Items = ConvertHelper.ConvertMediaLibraryItemListToPlaylistItemList(result) }) != -1)
                    {
                        SendToNewPlaylistKeyWord?.Invoke(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(Player.GetString("MsgListNameInvaildate"), null, 0, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmsMediaResult_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tsmiSelectedCount.Text = Player.GetString("SelectedCount", lvResult.SelectedObjects.Count.ToString());
            tsmiMediaSendToPlaylist.DropDownItems.Clear();
            for (int i = 0; i < PlaylistHelper.Count; i++)
            {
                if (PlaylistHelper.Playlists[i].IsActive)
                    continue;
                ToolStripItem tsitem = new ToolStripMenuItem(PlaylistHelper.Playlists[i].Name);
                tsitem.Tag = i;
                tsitem.Click += (object? sender, EventArgs e) => { PlaylistHelper.Playlists[Convert.ToInt32(((ToolStripMenuItem)sender).Tag)].Items.AddRange(ConvertHelper.ConvertAudioInfoListToPlaylistItemList(lvResult.SelectedObjects.Cast<AudioInfo>().ToList())); };
                tsmiMediaSendToPlaylist.DropDownItems.Add(tsitem);
            }
        }

        private void tsmiMediaPlay_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedIndex != -1)
                PlayItem?.Invoke(sender, e);
        }

        private void tsmiMediaLineUp_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedIndex != -1)
                LineUpItem?.Invoke(sender, e);
        }

        private void tsmiMediaSendToNewPlaylist_Click(object sender, EventArgs e)
        {
            if (result.Count != 0)
            {
                string name = Interaction.InputBox(Player.GetString("MsgAddPlaylist"), Player.GetString("ProgramName"));
                if (name != "")
                {
                    if (PlaylistHelper.Add(new Playlist(name) { Items = ConvertHelper.ConvertAudioInfoListToPlaylistItemList(lvResult.SelectedObjects.Cast<AudioInfo>().ToList()) }) != -1)
                    {
                        SendToNewPlaylistItem?.Invoke(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(Player.GetString("MsgListNameInvaildate"), null, 0, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsmiMediaRemove_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedObjects.Count != 0)
            {
                if (AllMode)
                {
                    lvResult.SelectedObjects.Cast<AudioInfo>().ToList().ForEach(x => MediaLibraryHelper.Remove(x.File));
                    lvResult.SetObjects(MediaLibraryHelper.Library.Values);
                }
                else
                {
                    var removeList = lvResult.SelectedObjects.Cast<AudioInfo>().ToList();
                    removeList.ForEach(x => result.Remove(x.File));
                    removeList.ForEach(x => MediaLibraryHelper.Remove(x.File));
                    lvResult.SetObjects(result.Values);
                }
                lvResult.SelectedObjects = null;
            }
        }

        private void tsmiMediaExplorer_Click(object sender, EventArgs e)
        {
            if (lvResult.SelectedObjects.Count != 0)
            {
                Utils.ExploreFile(((AudioInfo)lvResult.SelectedObject).File);
            }
        }

        private void tsmiFileInfo_Click(object sender, EventArgs e)
        {
            new InformationForm() { Tag = ((AudioInfo)lvResult.SelectedObject).File }.ShowDialog();
        }

        private void lvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResult.SelectedIndex != -1)
            {
                pbAlbumPicture.Image = AudioInfoHelper.GetAudioPicture(SelectedItem.File);
                lblAlbum.Text = SelectedItem.Tag.Album;
                lblArtist.Text = SelectedItem.Tag.Artist;
                lblTitle.Text = SelectedItem.Tag.Title;
                lblFileName.Text = Path.GetFileName(SelectedItem.File);
                lblGenre.Text = SelectedItem.Tag.Genre;
                label1.SendToBack();
            }
            else
            {
                label1.BringToFront();
            }
        }

        private void sbFilterKey_SearchStart(object sender, EventArgs e)
        {
            TextMatchFilter? filter = null;
            if (!string.IsNullOrEmpty(sbFilterKey.Text))
            {
                filter = TextMatchFilter.Contains(lvKeyWord, sbFilterKey.Text);
                if (lvKeyWord.DefaultRenderer == null)
                    lvKeyWord.DefaultRenderer = new HighlightTextRenderer(filter);

            }
            lvKeyWord.AdditionalFilter = filter;
        }

        private void sbFilterResult_SearchStart(object sender, EventArgs e)
        {
            TextMatchFilter? filter = null;
            if (!string.IsNullOrEmpty(sbFilterResult.Text))
            {
                filter = TextMatchFilter.Contains(lvResult, sbFilterResult.Text);
                if (lvResult.DefaultRenderer == null)
                    lvResult.DefaultRenderer = new HighlightTextRenderer(filter);

            }
            lvResult.AdditionalFilter = filter;
        }
    }
}
