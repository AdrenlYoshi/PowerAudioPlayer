using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.UI

{
    public partial class PlaylistEditorForm : BaseForm
    {
        public PlaylistEditorForm()
        {
            InitializeComponent();
            Location = Settings.Default.PlaylistEditorFormLocation;
            playlistEditor.IsEditActivePlaylist = true;
            playlistEditor.RefreshItems();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Player.WM_REFRESHPLAYLISTVIEW:
                    playlistEditor.RefreshItems();
                    break;
                case Player.WM_LOCATETO:
                    tsbtnLocateTo_Click(new object(), new EventArgs());
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void tsbtnLocateTo_Click(object sender, EventArgs e)
        {
            playlistEditor.EnsureVisible(Player.playIndex);
        }

        private void playlistEditor_PlayItem(object sender, EventArgs e)
        {
            NativeAPI.SendMessage(Owner.Handle, Player.WM_PLAY, PlaylistHelper.ActivePlaylist.Items.IndexOf(playlistEditor.SelectedItem), 0);
        }

        private void PlaylistEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void PlaylistEditorForm_LocationChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                Settings.Default.PlaylistEditorFormLocation = Location;
        }
    }
}