using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    public partial class MediaLibrarySettingsPage : UserControl
    {
        OLVColumn olvColumn1 = new OLVColumn(Player.GetString("Directory"), "Directory");
        OLVColumn olvColumn2 = new OLVColumn(Player.GetString("IncludingSubDir"), "IncludeSubDir") { CheckBoxes = true, TextAlign = HorizontalAlignment.Center };
        OLVColumn olvColumn3 = new OLVColumn(Player.GetString("Action"), "") { ButtonSizing = OLVColumn.ButtonSizingMode.CellBounds, IsButton = true, AspectGetter = delegate (object rowObject) { return Player.GetString("Delete"); } };

        public Form? Owner
        {
            get; set;
        }

        public MediaLibrarySettingsPage()
        {
            InitializeComponent();

            cbMediaLibraryAutoRemove.DataBindings.Add("Checked", Settings.Default, "MediaLibraryAutoRemove", true, DataSourceUpdateMode.OnPropertyChanged);
            cbMediaLibraryStartUpRefresh.DataBindings.Add("Checked", Settings.Default, "MediaLibraryStartUpUpdate", true, DataSourceUpdateMode.OnPropertyChanged);
            cbPlaylistEditorShowFileNameColumn.DataBindings.Add("Checked", Settings.Default, "PlaylistEditorShowFileNameColumn", true, DataSourceUpdateMode.OnPropertyChanged);
            cbRecordPlayHistroy.DataBindings.Add("Checked", Settings.Default, "RecordPlayHistroy", true, DataSourceUpdateMode.OnPropertyChanged);


            lvMediaLibraryDirs.Columns.AddRange([olvColumn1, olvColumn2, olvColumn3]);
            if (!Utils.IsDesignMode())
                lvMediaLibraryDirs.SetObjects(Settings.Default.MediaLibraryDirectories);
        }

        private void btnAddDir_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
            CommonFileDialogCheckBox checkBox = new CommonFileDialogCheckBox();
            checkBox.Text = Player.GetString("IncludingSubDir");
            commonOpenFileDialog.Controls.Add(checkBox);
            commonOpenFileDialog.IsFolderPicker = true;
            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok && commonOpenFileDialog.FileName != null)
            {
                if (!Settings.Default.MediaLibraryDirectories.Exists(x => x.Directory.Equals(commonOpenFileDialog.FileName)))
                    Settings.Default.MediaLibraryDirectories.Add(new MediaLibraryDirectory(commonOpenFileDialog.FileName, checkBox.IsChecked));
                lvMediaLibraryDirs.SetObjects(Settings.Default.MediaLibraryDirectories);
            }
        }

        private void lvMediaLibraryDirs_ButtonClick(object sender, CellClickEventArgs e)
        {
            Settings.Default.MediaLibraryDirectories.Remove((MediaLibraryDirectory)e.Model);
            lvMediaLibraryDirs.SetObjects(Settings.Default.MediaLibraryDirectories);
        }

        private void btnRefreshMediaLibrary_Click(object sender, EventArgs e)
        {
            if (Owner != null)
                NativeAPI.SendMessage(Owner.Handle, Player.WM_REFRESHMEDIALIBRARY, 0, 0);
        }

        private void btnCleanUpMediaLibrary_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Player.GetString("MsgCleanUpMediaLibrary"), Player.GetString("ProgramName"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int removeCount = MediaLibraryHelper.CleanUpMediaLibrary();
                MessageBox.Show(Player.GetString("MsgCleanUpMediaLibraryOK", removeCount), Player.GetString("ProgramName"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveMediaLibrary_Click(object sender, EventArgs e)
        {
            MediaLibraryHelper.SaveMediaLibrary();
        }

        private void btnClearMediaLibrary_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Player.GetString("MsgClearMediaLibrary"), Player.GetString("ProgramName"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               MediaLibraryHelper.ClearMediaLibrary();
            }
        }
    }
}