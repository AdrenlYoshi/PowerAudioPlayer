using SkiaSharp;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace PowerAudioPlayer.UI.CustomControls
{
    public partial class LyricsView : UserControl
    {
        public List<LyricsLine> LyricsLines = new List<LyricsLine>();
        public int LineIndex = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int LineMargin { get; set; } = 20;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HighlightColor { get; set; } = Color.Red;

        public class LyricsLine
        {
            public string Text { get; set; } = string.Empty;

            public double Time { get; set; } = 0;
        }

        public LyricsView()
        {
            InitializeComponent();
        }

        public void ClearLyrics()
        {
            LyricsLines.Clear();
        }

        public void LoadLyrics(string lrcText)
        {
            ClearLyrics();
            foreach (string str in lrcText.Split('\n'))
            {
                if (str.Length > 0 && str.IndexOf(":") != -1)
                {
                    TimeSpan time = GetTime(str);
                    string lrc = str.Split(']')[1];
                    try
                    {
                        LyricsLines.Add(new LyricsLine()
                        {
                            Text = lrc,
                            Time = time.TotalMilliseconds
                        });
                    }
                    catch { }
                }
            }
        }

        public void RollTo(double time)
        {
            for (int i = 0; i < LyricsLines.Count; i++)
            {
                try
                {
                    if (time >= LyricsLines[i].Time && time < LyricsLines[i + 1].Time)
                    {
                        LineIndex = i;
                    }
                    if(time >= LyricsLines[LyricsLines.Count - 1].Time)
                    {
                        LineIndex = LyricsLines.Count - 1;
                    }
                    surface.Invalidate();
                }
                catch
                {
                    LineIndex = LyricsLines.Count - 1;
                    surface.Invalidate();
                }
            }
        }

        public string GetCurrentLineText()
        {
            return new string(string.Empty);
        }

        public TimeSpan GetTime(string str)
        {
            Regex reg = new Regex(@"\[(?<time>.*)\]", RegexOptions.IgnoreCase);
            string timestr = reg.Match(str).Groups["time"].Value;
            int m = Convert.ToInt32(timestr.Split(':')[0]);
            int s = 0, f = 0;
            if (timestr.Split(':')[1].IndexOf(".") != -1)
            {
                s = Convert.ToInt32(timestr.Split(':')[1].Split('.')[0]);
                f = Convert.ToInt32(timestr.Split(':')[1].Split('.')[1]);
            }
            else
            {
                s = Convert.ToInt32(timestr.Split(':')[1]);
            }
            return new TimeSpan(0, 0, m, s, f);

        }

        private void surface_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            SKCanvas? canvas = e.Surface.Canvas;
            canvas.Clear();
            if (LyricsLines.Count > 0)
            {
                SKFont font = new SKFont(SKTypeface.FromFamilyName(Font.FontFamily.Name));
                SKPaint paintNormal = new SKPaint { Color = new SKColor(ForeColor.R, ForeColor.G, ForeColor.B, ForeColor.A) };
                SKPaint paintHighlight = new SKPaint { Color = SKColors.Red };
                font.MeasureText(LyricsLines[LineIndex].Text, out SKRect rect, paintHighlight);
                int midY = (int)(Height / 2 - rect.Height / 2);
                canvas.DrawText(LyricsLines[LineIndex].Text, 10, midY, font, paintHighlight);
                int Counter = LineIndex;
                for (int i = midY; i <= Height; i += LineMargin)
                {
                    if (i == midY) continue;
                    Counter++;
                    try
                    {
                        canvas.DrawText(LyricsLines[Counter].Text, 10, i, font, paintNormal);
                    }
                    catch
                    {
                        canvas.DrawText(string.Empty, 0, i, font, paintNormal);
                    }
                }
                Counter = LineIndex;
                for (int i = midY; i >= 0; i -= LineMargin)
                {
                    if (i == midY) continue;
                    Counter--;
                    try
                    {
                        canvas.DrawText(LyricsLines[Counter].Text, 10, i, font, paintNormal);
                    }
                    catch
                    {
                        canvas.DrawText(string.Empty, 0, i, font, paintNormal);
                    }
                }
            }
        }

        private void LyricsView_SizeChanged(object sender, EventArgs e)
        {
            surface.Invalidate();
        }
    }
}
