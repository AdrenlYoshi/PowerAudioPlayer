﻿using PowerAudioPlayer.Controllers;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Color = System.Windows.Media.Color;
using MessageBox = System.Windows.MessageBox;
using Point = System.Windows.Point;
using UserControl = System.Windows.Controls.UserControl;

namespace PowerAudioPlayer
{
    /// <summary>
    /// LyricsView.xaml 的交互逻辑
    /// </summary>
    public partial class LyricsView : UserControl
    {
        public static readonly DependencyProperty ItemsMarginProperty = DependencyProperty.Register("ItemsMargin", typeof(int), typeof(LyricsView), new PropertyMetadata(10, new PropertyChangedCallback((DependencyObject d, DependencyPropertyChangedEventArgs e) =>
        {
            LyricsView LyricsView = (LyricsView)d;
            if (d != null)
            {
                LyricsView.IMargin = (int)e.NewValue;
                if (LyricsView.Lrcs.Any())
                {
                    foreach (var item in LyricsView.Lrcs)
                    {
                        item.Value.c_LrcTb.Margin = new Thickness(0, LyricsView.IMargin, 0, 0);
                    }
                }
            }
        })));

        //public static readonly DependencyProperty NormalColorProperty = DependencyProperty.Register("NormalColor", typeof(SolidColorBrush), typeof(LyricsView), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0, 0, 0)), new PropertyChangedCallback((DependencyObject d, DependencyPropertyChangedEventArgs e) =>
        //{
        //    LyricsView LyricsView = (LyricsView)d;
        //    if (d != null)
        //    {
        //        LyricsView.NormalLrcColor = (SolidColorBrush)e.NewValue;
        //        if (LyricsView.Lrcs.Any())
        //        {
                    
        //            foreach (var item in LyricsView.Lrcs)
        //            {
        //                if (!item.Value.Equals(LyricsView.foucslrc))
        //                    item.Value.c_LrcTb.Foreground = LyricsView.NormalLrcColor;
        //            }

        //        }
        //    }
        //})));

        public static readonly DependencyProperty HighLightColorProperty = DependencyProperty.Register("HighLightColor", typeof(SolidColorBrush), typeof(LyricsView), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(255, 0, 0)), new PropertyChangedCallback((DependencyObject d, DependencyPropertyChangedEventArgs e) =>
        {
            LyricsView LyricsView = (LyricsView)d;
            if (d != null)
            {
                LyricsView.HighLightColor = (SolidColorBrush)e.NewValue;
                if (LyricsView.Lrcs.Any())
                {
                    LyricsView.foucslrc.c_LrcTb.Foreground = LyricsView.HighLightColor;
                }
            }
        })));

        //[Bindable(true)]
        //[Category("Appearance")]
        //public SolidColorBrush NormalColor
        //{
        //    get { return NormalLrcColor; }
        //    set { NormalLrcColor = value; }
        //}

        [Bindable(true)]
        [Category("Appearance")]
        public SolidColorBrush HighLightColor
        {
            get { return FoucsLrcColor; }
            set { FoucsLrcColor = value; }
        }

        [Bindable(true)]
        [Category("Appearance")]
        public int ItemsMargin
        {
            get { return (int)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        #region 歌词模型
        public class LrcModel
        {
            /// <summary>
            /// 歌词所在控件
            /// </summary>
            public TextBlock c_LrcTb { get; set; }

            /// <summary>
            /// 歌词字符串
            /// </summary>
            public string LrcText { get; set; }

            /// <summary>
            /// 时间
            /// </summary>
            public string Time { get; set; }
        }
        #endregion

        #region 变量
        //歌词集合
        public Dictionary<double, LrcModel> Lrcs = new Dictionary<double, LrcModel>();

        //添加当前焦点歌词变量
        public LrcModel foucslrc { get; set; }
        //当前焦点所在歌词集合位置
        public int FoucsLrcLocation { get; set; } = -1;
        //非焦点歌词颜色
        //public SolidColorBrush NormalLrcColor = new SolidColorBrush(Colors.Black);
        //焦点歌词颜色
        public SolidColorBrush FoucsLrcColor = new SolidColorBrush(Colors.Red);

        public int IMargin = 10;
        #endregion
        public LyricsView()
        {
            InitializeComponent();
        }

        #region 加载歌词

        public void ClearLrc()
        {
            Lrcs.Clear();
            lrcItems.Children.Clear();
        }

        public void LoadLrc(string lrcstr)
        {
            ClearLrc();
            //循环以换行\n切割出歌词
            foreach (string str in lrcstr.Split('\n'))
            {
                //过滤空行，判断是否存在时间
                if (str.Length > 0 && str.IndexOf(":") != -1)
                {
                    //歌词时间
                    TimeSpan time = GetTime(str);
                    //歌词取]后面的就行了
                    string lrc = str.Split(']')[1];
                    TextBlock c_lrcbk = new TextBlock();
                    //赋值
                    c_lrcbk.MouseDown += (sender, e) =>
                    {
                        string copyStr = ((TextBlock)sender).Text.Replace("\0",  " ");
                        System.Windows.Clipboard.SetDataObject(copyStr);
                        MessageBox.Show(Player.GetString("MsgCopyed", copyStr), Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButton.OK, MessageBoxImage.Information);
                    };
                    c_lrcbk.Text = lrc;
                    c_lrcbk.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                    //c_lrcbk.Foreground = NormalLrcColor;
                    if (lrcItems.Children.Count > 0)
                    {
                        c_lrcbk.Margin = new Thickness(0, IMargin, 0, 0);
                    }
                    //添加到集合，方便日后操作
                    try
                    {
                        Lrcs.Add(time.TotalMilliseconds, new LrcModel()
                        {
                            c_LrcTb = c_lrcbk,
                            LrcText = lrc,
                            Time = time.TotalMilliseconds.ToString()
                        });
                    }
                    catch { }
                    lrcItems.Children.Add(c_lrcbk);

                }
            }
        }

        //正则表达式提取时间

        public TimeSpan GetTime(string str)
        {
            Regex reg = new Regex(@"\[(?<time>.*)\]", RegexOptions.IgnoreCase);
            string timestr = reg.Match(str).Groups["time"].Value;

            //获得分
            int m = Convert.ToInt32(timestr.Split(':')[0]);
            //判断是否有小数点
            int s = 0, f = 0;
            if (timestr.Split(':')[1].IndexOf(".") != -1)
            {
                //有
                s = Convert.ToInt32(timestr.Split(':')[1].Split('.')[0]);
                //获得毫秒位
                f = Convert.ToInt32(timestr.Split(':')[1].Split('.')[1]);

            }
            else
            {
                //没有
                s = Convert.ToInt32(timestr.Split(':')[1]);

            }
            return new TimeSpan(0, 0, m, s, f);

        }

        #endregion

        #region 歌词滚动
        /// <summary>
        /// 歌词滚动、定位焦点
        /// </summary>
        /// <param name="nowtime"></param>
        public void LrcRoll(double nowtime)
        {
            if (!Lrcs.Any())
                return;
            if (foucslrc == null)
            {
                foucslrc = Lrcs.Values.First();
                foucslrc.c_LrcTb.Foreground = FoucsLrcColor;
            }
            else
            {
                if (nowtime < Convert.ToDouble(Lrcs.First().Value.Time))
                {
                    scrollViewer.ScrollToVerticalOffset(0);
                    foucslrc.c_LrcTb.Foreground = Foreground;
                }
                //查找焦点歌词
                IEnumerable<KeyValuePair<double, LrcModel>> s = Lrcs.Where(m => nowtime >= m.Key);
                if (s.Any())
                {
                    LrcModel lm = s.Last().Value;
                    foucslrc.c_LrcTb.Foreground = Foreground;
                    foucslrc = lm;
                    foucslrc.c_LrcTb.Foreground = FoucsLrcColor;
                    //定位歌词在控件中间区域
                    ResetLrcviewScroll();
                }
            }
        }
        #endregion
        #region 调整歌词控件滚动条位置
        public void ResetLrcviewScroll()
        {
            //获得焦点歌词位置
            GeneralTransform gf = foucslrc.c_LrcTb.TransformToVisual(lrcItems);
            Point p = gf.Transform(new Point(0, 0));

            //计算滚动位置（p.Y是焦点歌词控件(c_LrcTb)相对于父级控件lrcItems(StackPanel)的位置）
            //拿焦点歌词位置减去滚动区域控件高度除以2的值得到的【大概】就是歌词焦点在滚动区域控件的位置
            double os = p.Y - (scrollViewer.ActualHeight / 2) + 10;
            //滚动
            scrollViewer.ScrollToVerticalOffset(os);

        }
        #endregion
    }
}
