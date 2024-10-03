using PowerAudioPlayer.Controllers;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms.Integration;
using Utils = PowerAudioPlayer.Controllers.Utils;
using System.Globalization;
using System.Windows.Data;
using Binding = System.Windows.Data.Binding;
using PowerAudioPlayer.Model;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.UI
{
    public partial class LyricsForm : BaseForm
    {
        LyricsView lyricsView = new LyricsView() { ItemsMargin = Settings.Default.LyricsItemsMargin, HighLightColor = new System.Windows.Media.SolidColorBrush(Utils.GetMediaColorFromDrawingColor(Settings.Default.LyricsHighlightColor)) };

        public LyricsForm()
        {
            InitializeComponent();
            Controls.Add(new ElementHost() { Child = lyricsView, Dock = DockStyle.Fill });
            lyricsView.Foreground = new System.Windows.Media.SolidColorBrush(Utils.GetMediaColorFromDrawingColor(ForeColor));
            lyricsView.DataContext = Settings.Default;
            lyricsView.SetBinding(LyricsView.ItemsMarginProperty, "LyricsItemsMargin");
            lyricsView.SetBinding(LyricsView.HighLightColorProperty, new Binding("LyricsHighlightColor") { Converter = new SolidColorBrushValueConverter(), Mode = BindingMode.TwoWay });
            //lyricsView.SetBinding(LyricsView.NormalColorProperty, new Binding("LyricsNormalColor") { Converter = new SolidColorBrushValueConverter(), Mode = BindingMode.TwoWay}); 
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Player.WM_LOADLYRICS:
                    LoadLyrics();
                    break;
                case Player.WM_CLEARLRC:
                    lyricsView.ClearLrc();
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
            lyricsView.LrcRoll(nowTime);
        }

        private void LoadLyrics()
        {
            string lrc = string.Empty;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            lyricsView.ClearLrc();
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
            lyricsView.LoadLrc(lrc);
        }

        private void LyricsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void LyricsForm_ForeColorChanged(object sender, EventArgs e)
        {
            lyricsView.Foreground = new System.Windows.Media.SolidColorBrush(Utils.GetMediaColorFromDrawingColor(ForeColor));
        }
    }

    public class SolidColorBrushValueConverter : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Color)
                return new System.Windows.Media.SolidColorBrush(Utils.GetMediaColorFromDrawingColor((Color)value));
            return null;
        }

        public object? ConvertBack(object value, Type sourceType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}