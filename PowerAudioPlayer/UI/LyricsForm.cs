using PowerAudioPlayer.Controllers;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using PowerAudioPlayer.Model;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.UI
{
    public partial class LyricsForm : BaseForm
    {
        public LyricsForm()
        {
            InitializeComponent();
            Location = Settings.Default.LyricsFormLocation;
            
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Player.WM_LOADLYRICS:
                    LoadLyrics();
                    break;
                case Player.WM_CLEARLRC:
                    lyricsView1.ClearLyrics();
                    break;
                case Player.WM_LRCROLL:
                    ScrollLyrics(m.WParam);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void ScrollLyrics(double nowTime)
        {
            lyricsView1.RollTo(nowTime);
        }

        private void LoadLyrics()
        {
            string lrc = string.Empty;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            lyricsView1.ClearLyrics();
            if (Player.Core.GetChannelInfo().type == AudioType.MIDI)
            {
                lrc = Player.Core.GetMIDILyrics();
            }
            else
            {
                int index = Player.playIndex;
                if (index == -1) return;
                string file = Path.GetDirectoryName(PlaylistHelper.ActivePlaylist.Items[Player.playIndex].File) + "\\" + Path.GetFileNameWithoutExtension(PlaylistHelper.ActivePlaylist.Items[Player.playIndex].File) + ".lrc";
                if (!File.Exists(file)) return;
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    string? line;
                    using (StreamReader sr = new StreamReader(fs))
                        while ((line = sr.ReadLine()) != null)
                            if (line != "" && Regex.IsMatch(line, @"\[(\d+:\d+\.\d+)\]"))
                                lrc += line + "\n\n\n\n";
                }
            }
            lyricsView1.LoadLyrics(lrc);
        }

        private void LyricsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void LyricsForm_ForeColorChanged(object sender, EventArgs e)
        {
            lyricsView1.ForeColor = ForeColor;
        }

        private void LyricsForm_LocationChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                Settings.Default.LyricsFormLocation = Location;
        }
    }
}