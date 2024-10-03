using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Model;
using System.ComponentModel;
using System.IO;
using Microsoft.VisualBasic;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.UI.CustomControls
{
    public partial class PlaylistEditor : UserControl
    {
        private readonly OLVColumn olvColumn1 = new OLVColumn(Player.GetString("DisplayTitle"), "DisplayTitle") { Width = 430, MinimumWidth = 20 };
        private readonly OLVColumn olvColumn2 = new OLVColumn(Player.GetString("Length"), "Length") { Width = 70, MinimumWidth = 10, AspectGetter = delegate (object rowObject) { return Utils.FormatTimeSecond(((PlaylistItem)rowObject).Length); } };
        private readonly OLVColumn olvColumn3 = new OLVColumn(Player.GetString("FileName"), "File") { Width = 420, MinimumWidth = 20, AspectGetter = delegate (object rowObject) { return Path.GetFileName(((PlaylistItem)rowObject).File); } };
        private DoWorkEventHandler doWorkEvent = (object? sender, DoWorkEventArgs e) => { };
        private int workingPlaylistIndex = -1;
        public event EventHandler? PlayItem;
        public event EventHandler? LineUpItem;
        public event EventHandler? WorkStart;
        public event EventHandler? WorkComplete;

        public new bool DesignMode
        {
            get => Utils.IsDesignMode();
        }

        private bool _isEditActivePlaylist = false;
        public bool IsEditActivePlaylist
        {
            get
            {
                return _isEditActivePlaylist;
            }
            set
            {
                if (value)
                {
                    tsmiImportFormActivePlaylist.Visible = false;
                    tsmiSendTo.Visible = false;
                    tsmiSendToMediaLibrary1.Visible = false;
                    tsmilu1.Visible = false;
                    tsmPlay.Visible = false;
                }
                else
                {
                    tsmiImportFormActivePlaylist.Visible = true;
                    tsmiSendTo.Visible = true;
                    tsmiSendToMediaLibrary1.Visible = true;
                    tsmilu1.Visible = true;
                    tsmPlay.Visible = true;
                }
                _isEditActivePlaylist = value;
            }
        }

        private int _editPlaylistIndex = 0;
        [Browsable(false)]
        public int EditPlaylistIndex
        {
            get { return _editPlaylistIndex; }
            set
            {
                _editPlaylistIndex = value;
                if (DesignMode)
                {
                    lvPlaylist.SetObjects(null);
                }
                else
                {
                    RefreshItems();
                }
            }
        }

        [Browsable(false)]
        public IList<PlaylistItem> SelectedItems { get => lvPlaylist.SelectedObjects.Cast<PlaylistItem>().ToList(); }

        [Browsable(false)]
        public PlaylistItem SelectedItem { get => (PlaylistItem)lvPlaylist.SelectedObject; }

        public PlaylistEditor()
        {
            InitializeComponent();
            TextOverlay? textOverlay = lvPlaylist.EmptyListMsgOverlay as TextOverlay;
            if (textOverlay != null)
            {
                textOverlay.BackColor = Color.Transparent;
                textOverlay.TextColor = ForeColor;
                textOverlay.Font = Font;
                textOverlay.BorderColor = Color.Transparent;
            }
            if (Settings.Default.PlaylistEditorShowFileNameColumn)
            {
                lvPlaylist.Columns.AddRange([olvColumn1, olvColumn2, olvColumn3]);
            }
            else
            {
                lvPlaylist.Columns.AddRange([olvColumn1, olvColumn2]);
            }
            if (!DesignMode)
            {
                lvPlaylist.SetObjects(PlaylistHelper.Playlists[_editPlaylistIndex].Items);
            }
        }

        public void RefreshItems()
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            lvPlaylist.AdditionalFilter = null;
            tbFilter.Text = string.Empty;
            lvPlaylist.SetObjects(PlaylistHelper.Playlists[_editPlaylistIndex].Items);
            lvPlaylist.Refresh();
            RefreshStatus();
        }

        public void RefreshStatus()
        {
            lblTotalCount.Text = PlaylistHelper.Playlists[_editPlaylistIndex].Count.ToString();
            lblTotalLength.Text = Utils.FormatTimeSecond(PlaylistHelper.Playlists[_editPlaylistIndex].TotalLength);
        }

        public void EnsureVisible(int index)
        {
            if (index != -1)
            {
                lvPlaylist.EnsureVisible(index);
            }
        }

        public void EnsureVisible(PlaylistItem item)
        {
            lvPlaylist.SelectedObject = item;
        }

        private void IsEnableControls(bool enable)
        {
            lvPlaylist.Enabled = enable;
            msPl.Enabled = enable;
            tbFilter.Enabled = enable;
        }

        private void lvPlaylist_DoubleClick(object sender, EventArgs e)
        {
            PlayItem?.Invoke(this, e);
        }

        private void tsmiPlay_Click(object sender, EventArgs e)
        {
            PlayItem?.Invoke(this, e);
        }

        private void tsmilu_Click(object sender, EventArgs e)
        {
            LineUpItem?.Invoke(this, e);
        }

        private void tsmiSendToMediaLibrary_Click(object sender, EventArgs e)
        {
            foreach (PlaylistItem item in lvPlaylist.SelectedObjects)
            {
                MediaLibraryHelper.Add(item.File);
            }
        }

        private void tsmiAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = Player.Core.GetAllSupportedFileFilter(Player.GetString("AllSupportedFileFilter"), Player.GetString("AllFiles"));
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                doWorkEvent = (object? sender, DoWorkEventArgs e) =>
                {
                    if (e.Argument != null)
                    {
                        string[] files = (string[])e.Argument;
                        foreach (string file in files)
                        {
                            if (backgroundWorker.CancellationPending)
                            {
                                break;
                            }
                            PlaylistHelper.Playlists[workingPlaylistIndex].Add(file);
                        }
                    }
                };
                backgroundWorker.DoWork += doWorkEvent;
                workingPlaylistIndex = _editPlaylistIndex;
                backgroundWorker.RunWorkerAsync(openFileDialog.FileNames);
                IsEnableControls(false);
                lblStatus.Text = Player.GetString("MsgAddingFiles");
                lblStatus.Visible = true;
                WorkStart?.Invoke(this, e);
            }
        }

        private void tsmiAddFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
            CommonFileDialogCheckBox checkBox = new CommonFileDialogCheckBox();
            checkBox.Text = Player.GetString("IncludingSubDir");
            commonOpenFileDialog.Controls.Add(checkBox);
            commonOpenFileDialog.IsFolderPicker = true;
            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok && commonOpenFileDialog.FileName != null)
            {
                doWorkEvent = (object? sender, DoWorkEventArgs e) =>
                {
                    if (e.Argument != null)
                    {
                        var args = (FileSearchArgs)e.Argument;
                        string[] supportedExtensions = Player.Core.GetAllSupportedFileArray();
                        IEnumerable<string> files = Utils.SearchFiles(args.Directory, supportedExtensions, args.SearchSubDir);
                        foreach (string file in files)
                        {
                            if (backgroundWorker.CancellationPending)
                            {
                                break;
                            }
                            PlaylistHelper.Playlists[workingPlaylistIndex].Add(file);
                        }
                    }
                };
                backgroundWorker.DoWork += doWorkEvent;
                workingPlaylistIndex = _editPlaylistIndex;
                backgroundWorker.RunWorkerAsync(new FileSearchArgs(commonOpenFileDialog.FileName, checkBox.IsChecked));
                IsEnableControls(false);
                lblStatus.Text = Player.GetString("MsgAddingFiles");
                lblStatus.Visible = true;
                WorkStart?.Invoke(this, e);
            }
        }

        private void tsmiAddURL_Click(object sender, EventArgs e)
        {
            string url = Interaction.InputBox(Player.GetString("MsgAddURL"), Player.GetString("ProgramName"));
            if (url.Length > 0)
            {
                PlaylistHelper.Playlists[_editPlaylistIndex].Add(url);
                RefreshItems();
            }
        }

        private void tsmiRemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (PlaylistItem item in lvPlaylist.SelectedObjects)
            {
                PlaylistHelper.Playlists[_editPlaylistIndex].Remove(item);
            }
            RefreshItems();
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            PlaylistHelper.Playlists[_editPlaylistIndex].Clear();
            RefreshItems();
        }

        private void tsmiKeep_Click(object sender, EventArgs e)
        {
            foreach (PlaylistItem item in PlaylistHelper.Playlists[_editPlaylistIndex].Items)
            {
                if (lvPlaylist.SelectedObjects.IndexOf(item) != -1)
                    continue;
                PlaylistHelper.Playlists[_editPlaylistIndex].Remove(item);
            }
            RefreshItems();
        }

        private void tsmiImportFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Player.GetString("FilterPlaylist");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PlaylistHelper.ReplacePlaylist(openFileDialog.FileName, EditPlaylistIndex);
            }
            RefreshItems();
        }

        private void tsmiImportFormActivePlaylist_Click(object sender, EventArgs e)
        {
            PlaylistHelper.CopyToPlaylist(PlaylistHelper.ActivePlaylist.Items, _editPlaylistIndex);
            RefreshItems();
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Player.GetString("FilterPlaylist");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PlaylistHelper.SavePlaylist(saveFileDialog.FileName, EditPlaylistIndex);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            WorkComplete?.Invoke(this, e);
            backgroundWorker.DoWork -= doWorkEvent;
            RefreshItems();
            IsEnableControls(true);
            lblStatus.Visible = false;
            workingPlaylistIndex = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsmiSelectedCount.Text = Player.GetString("SelectedCount", lvPlaylist.SelectedObjects.Count.ToString());
        }

        private void tsmiMediaExplorer_Click(object sender, EventArgs e)
        {
            if (lvPlaylist.SelectedObjects.Count > 0)
            {
                Utils.ExploreFile(SelectedItem.File);
            }
        }

        private void tsmiFileInfo_Click(object sender, EventArgs e)
        {
            if (lvPlaylist.SelectedObjects.Count > 0)
            {
                new InformationForm() { Tag = SelectedItem.File }.ShowDialog();
            }
        }

        private void PlaylistEditor_DragDrop(object sender, DragEventArgs e)
        {
            string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop, false);
            if (files != null)
            {
                string[]? allFileFilter = Player.Core.GetAllSupportedFileArray();
                List<PlaylistItem> items = new List<PlaylistItem>();
                foreach (var file in files)
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (allFileFilter.Contains("*" + ext))
                    {
                        items.Add(PlaylistItem.FormFile(file));
                    }
                }
                if (items.Count > 0)
                {
                    PlaylistHelper.Playlists[_editPlaylistIndex].Items.AddRange(items);
                    RefreshItems();
                }
            }
        }

        private void PlaylistEditor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvPlaylist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                tsmiRemoveSelected_Click(sender, e);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            TextMatchFilter? filter = null;
            if (!string.IsNullOrEmpty(tbFilter.Text))
            {
                filter = TextMatchFilter.Contains(lvPlaylist, tbFilter.Text);
                if (lvPlaylist.DefaultRenderer == null)
                    lvPlaylist.DefaultRenderer = new HighlightTextRenderer(filter);

            }
            lvPlaylist.AdditionalFilter = filter;
        }
    }
}