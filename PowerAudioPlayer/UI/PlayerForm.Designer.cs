using PowerAudioPlayer.UI.CustomControls;
using Un4seen.Bass;

namespace PowerAudioPlayer
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            tmrPlayer = new System.Windows.Forms.Timer(components);
            tmrLyrics = new System.Windows.Forms.Timer(components);
            toolTip = new ToolTip(components);
            btnPlay = new Button();
            btnPause = new Button();
            btnStop = new Button();
            btnNext = new Button();
            lblDisplayTitle = new Label();
            picAlbum = new PictureBox();
            btnPrevious = new Button();
            trbPosition = new WinFormsExtendedControls.SelRangeTrackBar();
            trbVolume = new TrackBar();
            toolStrip = new ToolStrip();
            tsbtnOrderPlay = new WinFormsExtendedControls.ToolStripRadioButton();
            tsbtnShufflePlay = new WinFormsExtendedControls.ToolStripRadioButton();
            tsbtnTrackLoop = new WinFormsExtendedControls.ToolStripRadioButton();
            tsbtnPlaylistLoop = new WinFormsExtendedControls.ToolStripRadioButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbtnAPRepeat = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbtnSettings = new ToolStripButton();
            tsbtnSoundEffect = new ToolStripButton();
            tsbtnMediaLibraryForm = new ToolStripButton();
            tsddbToolbox = new ToolStripDropDownButton();
            tsmiSupportedFormat = new ToolStripMenuItem();
            tsmiCreateDesktopShortcut = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            lblTitle = new Label();
            lblAlbum = new Label();
            lblArtist = new Label();
            lblInfo = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblPosition = new Label();
            lblVolume = new Label();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblStatus1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbVolume).BeginInit();
            toolStrip.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            statusStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tmrPlayer
            // 
            tmrPlayer.Interval = 200;
            tmrPlayer.Tick += tmrPlayer_Tick;
            // 
            // tmrLyrics
            // 
            tmrLyrics.Interval = 200;
            tmrLyrics.Tick += tmrLyrics_Tick;
            // 
            // btnPlay
            // 
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Red;
            btnPlay.Image = Resources.Play;
            btnPlay.Location = new Point(43, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(34, 34);
            btnPlay.TabIndex = 1;
            toolTip.SetToolTip(btnPlay, "播放");
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.Image = Resources.Pause;
            btnPause.Location = new Point(83, 3);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(34, 34);
            btnPause.TabIndex = 2;
            toolTip.SetToolTip(btnPause, "暂停");
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Image = Resources.Stop;
            btnStop.Location = new Point(123, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(34, 34);
            btnStop.TabIndex = 3;
            toolTip.SetToolTip(btnStop, "停止");
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnNext
            // 
            btnNext.Image = Resources.Next;
            btnNext.Location = new Point(163, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(34, 34);
            btnNext.TabIndex = 4;
            toolTip.SetToolTip(btnNext, "下一个");
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblDisplayTitle
            // 
            lblDisplayTitle.AutoEllipsis = true;
            lblDisplayTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDisplayTitle, 2);
            lblDisplayTitle.Dock = DockStyle.Fill;
            lblDisplayTitle.Location = new Point(3, 0);
            lblDisplayTitle.Name = "lblDisplayTitle";
            lblDisplayTitle.Size = new Size(436, 17);
            lblDisplayTitle.TabIndex = 0;
            lblDisplayTitle.Text = "PowerAudioPlayer";
            lblDisplayTitle.TextAlign = ContentAlignment.MiddleCenter;
            toolTip.SetToolTip(lblDisplayTitle, "标题");
            lblDisplayTitle.UseMnemonic = false;
            lblDisplayTitle.DoubleClick += lblDisplayTitle_DoubleClick;
            // 
            // picAlbum
            // 
            picAlbum.BackColor = Color.Transparent;
            picAlbum.BorderStyle = BorderStyle.FixedSingle;
            picAlbum.Location = new Point(3, 20);
            picAlbum.Name = "picAlbum";
            picAlbum.Size = new Size(90, 90);
            picAlbum.SizeMode = PictureBoxSizeMode.Zoom;
            picAlbum.TabIndex = 54;
            picAlbum.TabStop = false;
            toolTip.SetToolTip(picAlbum, "专辑图片");
            // 
            // btnPrevious
            // 
            btnPrevious.Image = Resources.Previous;
            btnPrevious.Location = new Point(3, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(34, 34);
            btnPrevious.TabIndex = 0;
            toolTip.SetToolTip(btnPrevious, "上一个");
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // trbPosition
            // 
            trbPosition.AutoSize = false;
            trbPosition.Dock = DockStyle.Fill;
            trbPosition.Enabled = false;
            trbPosition.EnableSelRange = false;
            trbPosition.Location = new Point(92, 3);
            trbPosition.Name = "trbPosition";
            trbPosition.SelEnd = 0;
            trbPosition.SelStart = 0;
            trbPosition.Size = new Size(209, 20);
            trbPosition.TabIndex = 1;
            trbPosition.TickStyle = TickStyle.None;
            toolTip.SetToolTip(trbPosition, "位置");
            trbPosition.Scroll += trbPosition_Scroll;
            // 
            // trbVolume
            // 
            trbVolume.AutoSize = false;
            trbVolume.Dock = DockStyle.Fill;
            trbVolume.LargeChange = 2;
            trbVolume.Location = new Point(346, 3);
            trbVolume.Maximum = 100;
            trbVolume.Name = "trbVolume";
            trbVolume.Size = new Size(87, 20);
            trbVolume.TabIndex = 2;
            trbVolume.TickFrequency = 5;
            trbVolume.TickStyle = TickStyle.None;
            toolTip.SetToolTip(trbVolume, "音量");
            trbVolume.Value = 50;
            trbVolume.Scroll += trbVolume_Scroll;
            // 
            // toolStrip
            // 
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbtnOrderPlay, tsbtnShufflePlay, tsbtnTrackLoop, tsbtnPlaylistLoop, toolStripSeparator2, tsbtnAPRepeat, toolStripSeparator1, tsbtnSettings, tsbtnSoundEffect, tsbtnMediaLibraryForm, tsddbToolbox });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(442, 25);
            toolStrip.TabIndex = 0;
            // 
            // tsbtnOrderPlay
            // 
            tsbtnOrderPlay.CheckOnClick = true;
            tsbtnOrderPlay.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnOrderPlay.Image = Resources.OrderPlay;
            tsbtnOrderPlay.ImageTransparentColor = Color.Magenta;
            tsbtnOrderPlay.Name = "tsbtnOrderPlay";
            tsbtnOrderPlay.RadioButtonGroupId = 0;
            tsbtnOrderPlay.Size = new Size(23, 22);
            tsbtnOrderPlay.Tag = "OrderPlay|IgnoreColorize";
            tsbtnOrderPlay.Text = "顺序播放";
            tsbtnOrderPlay.Click += tsbtnPlayMode_Click;
            // 
            // tsbtnShufflePlay
            // 
            tsbtnShufflePlay.CheckOnClick = true;
            tsbtnShufflePlay.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnShufflePlay.Image = Resources.ShufflePlay;
            tsbtnShufflePlay.ImageTransparentColor = Color.Magenta;
            tsbtnShufflePlay.Name = "tsbtnShufflePlay";
            tsbtnShufflePlay.RadioButtonGroupId = 0;
            tsbtnShufflePlay.Size = new Size(23, 22);
            tsbtnShufflePlay.Tag = "ShufflePlay|IgnoreColorize";
            tsbtnShufflePlay.Text = "随机播放";
            tsbtnShufflePlay.Click += tsbtnPlayMode_Click;
            // 
            // tsbtnTrackLoop
            // 
            tsbtnTrackLoop.CheckOnClick = true;
            tsbtnTrackLoop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnTrackLoop.Image = Resources.TrackLoop;
            tsbtnTrackLoop.ImageTransparentColor = Color.Magenta;
            tsbtnTrackLoop.Name = "tsbtnTrackLoop";
            tsbtnTrackLoop.RadioButtonGroupId = 0;
            tsbtnTrackLoop.Size = new Size(23, 22);
            tsbtnTrackLoop.Tag = "TrackLoop|IgnoreColorize";
            tsbtnTrackLoop.Text = "单曲循环";
            tsbtnTrackLoop.Click += tsbtnPlayMode_Click;
            // 
            // tsbtnPlaylistLoop
            // 
            tsbtnPlaylistLoop.CheckOnClick = true;
            tsbtnPlaylistLoop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnPlaylistLoop.Image = Resources.PlaylistLoop;
            tsbtnPlaylistLoop.ImageTransparentColor = Color.Magenta;
            tsbtnPlaylistLoop.Name = "tsbtnPlaylistLoop";
            tsbtnPlaylistLoop.RadioButtonGroupId = 0;
            tsbtnPlaylistLoop.Size = new Size(23, 22);
            tsbtnPlaylistLoop.Tag = "PlaylistLoop|IgnoreColorize";
            tsbtnPlaylistLoop.Text = "列表循环";
            tsbtnPlaylistLoop.Click += tsbtnPlayMode_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbtnAPRepeat
            // 
            tsbtnAPRepeat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnAPRepeat.Image = Resources.ABRepeat;
            tsbtnAPRepeat.ImageTransparentColor = Color.Magenta;
            tsbtnAPRepeat.Name = "tsbtnAPRepeat";
            tsbtnAPRepeat.Size = new Size(23, 22);
            tsbtnAPRepeat.Text = "A-B重复";
            tsbtnAPRepeat.Click += tsbtnAPRepeat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbtnSettings
            // 
            tsbtnSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnSettings.Image = Resources.Settings;
            tsbtnSettings.ImageTransparentColor = Color.Magenta;
            tsbtnSettings.Name = "tsbtnSettings";
            tsbtnSettings.Size = new Size(23, 22);
            tsbtnSettings.Text = "设置";
            tsbtnSettings.Click += tsbtnSettings_Click;
            // 
            // tsbtnSoundEffect
            // 
            tsbtnSoundEffect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnSoundEffect.Image = Resources.Equalizer;
            tsbtnSoundEffect.ImageTransparentColor = Color.Magenta;
            tsbtnSoundEffect.Name = "tsbtnSoundEffect";
            tsbtnSoundEffect.Size = new Size(23, 22);
            tsbtnSoundEffect.Text = "声音效果";
            tsbtnSoundEffect.Click += tsbtnSoundEffect_Click;
            // 
            // tsbtnMediaLibraryForm
            // 
            tsbtnMediaLibraryForm.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnMediaLibraryForm.Image = Resources.Library;
            tsbtnMediaLibraryForm.ImageTransparentColor = Color.Magenta;
            tsbtnMediaLibraryForm.Name = "tsbtnMediaLibraryForm";
            tsbtnMediaLibraryForm.Size = new Size(23, 22);
            tsbtnMediaLibraryForm.Text = "媒体库";
            tsbtnMediaLibraryForm.Click += tsbtnMediaLibraryForm_Click;
            // 
            // tsddbToolbox
            // 
            tsddbToolbox.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbToolbox.DropDownItems.AddRange(new ToolStripItem[] { tsmiSupportedFormat, tsmiCreateDesktopShortcut, tsmiAbout });
            tsddbToolbox.Image = Resources.Toolbox;
            tsddbToolbox.ImageTransparentColor = Color.Magenta;
            tsddbToolbox.Name = "tsddbToolbox";
            tsddbToolbox.Size = new Size(29, 22);
            tsddbToolbox.Text = "工具";
            // 
            // tsmiSupportedFormat
            // 
            tsmiSupportedFormat.Name = "tsmiSupportedFormat";
            tsmiSupportedFormat.Size = new Size(209, 22);
            tsmiSupportedFormat.Text = "支持的格式列表";
            tsmiSupportedFormat.Click += tsmiSupportedFormat_Click;
            // 
            // tsmiCreateDesktopShortcut
            // 
            tsmiCreateDesktopShortcut.Name = "tsmiCreateDesktopShortcut";
            tsmiCreateDesktopShortcut.Size = new Size(209, 22);
            tsmiCreateDesktopShortcut.Text = "创建快捷方式到桌面";
            tsmiCreateDesktopShortcut.Click += tsmiCreateDesktopShortcut_Click;
            // 
            // tsmiAbout
            // 
            tsmiAbout.Image = Resources.PowerAudioPlayer;
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(209, 22);
            tsmiAbout.Text = "关于 PowerAudioPlayer";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(3, 26);
            lblTitle.Margin = new Padding(3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 17);
            lblTitle.TabIndex = 1;
            lblTitle.UseMnemonic = false;
            lblTitle.DoubleClick += lbl_DoubleClick;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(3, 72);
            lblAlbum.Margin = new Padding(3);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(0, 17);
            lblAlbum.TabIndex = 3;
            lblAlbum.UseMnemonic = false;
            lblAlbum.DoubleClick += lbl_DoubleClick;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(3, 49);
            lblArtist.Margin = new Padding(3);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(0, 17);
            lblArtist.TabIndex = 2;
            lblArtist.UseMnemonic = false;
            lblArtist.DoubleClick += lbl_DoubleClick;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(3, 3);
            lblInfo.Margin = new Padding(3);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 17);
            lblInfo.TabIndex = 0;
            lblInfo.UseMnemonic = false;
            lblInfo.DoubleClick += lbl_DoubleClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(lblInfo, 0, 0);
            tableLayoutPanel3.Controls.Add(lblArtist, 0, 2);
            tableLayoutPanel3.Controls.Add(lblTitle, 0, 1);
            tableLayoutPanel3.Controls.Add(lblAlbum, 0, 3);
            tableLayoutPanel3.Location = new Point(99, 20);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(6, 92);
            tableLayoutPanel3.TabIndex = 73;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Dock = DockStyle.Fill;
            lblPosition.Location = new Point(3, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(83, 26);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "00:00 / 00:00";
            lblPosition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Dock = DockStyle.Fill;
            lblVolume.Location = new Point(307, 0);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(33, 26);
            lblVolume.TabIndex = 3;
            lblVolume.Text = "50%";
            lblVolume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, lblStatus1 });
            statusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip.Location = new Point(0, 222);
            statusStrip.Name = "statusStrip";
            statusStrip.ShowItemToolTips = true;
            statusStrip.Size = new Size(442, 26);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 76;
            statusStrip.Text = "statusStrip";
            // 
            // lblStatus
            // 
            lblStatus.ImageScaling = ToolStripItemImageScaling.None;
            lblStatus.Margin = new Padding(3, 3, 3, 2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(32, 21);
            lblStatus.Text = "停止";
            // 
            // lblStatus1
            // 
            lblStatus1.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(36, 21);
            lblStatus1.Text = "就绪";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDisplayTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(picAlbum, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(442, 197);
            tableLayoutPanel1.TabIndex = 77;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(btnPrevious);
            flowLayoutPanel1.Controls.Add(btnPlay);
            flowLayoutPanel1.Controls.Add(btnPause);
            flowLayoutPanel1.Controls.Add(btnStop);
            flowLayoutPanel1.Controls.Add(btnNext);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 150);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(436, 44);
            flowLayoutPanel1.TabIndex = 78;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lblPosition, 0, 0);
            tableLayoutPanel2.Controls.Add(trbPosition, 1, 0);
            tableLayoutPanel2.Controls.Add(lblVolume, 2, 0);
            tableLayoutPanel2.Controls.Add(trbVolume, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 118);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(436, 26);
            tableLayoutPanel2.TabIndex = 78;
            // 
            // PlayerForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(442, 248);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PlayerForm";
            StartPosition = FormStartPosition.Manual;
            Text = "PowerAudioPlayer";
            FormClosing += PlayerForm_FormClosing;
            Shown += PlayerForm_Shown;
            LocationChanged += PlayerForm_LocationChanged;
            DragDrop += PlayerForm_DragDrop;
            DragEnter += PlayerForm_DragEnter;
            MouseWheel += PlayerForm_MouseWheel;
            ((System.ComponentModel.ISupportInitialize)picAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbVolume).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.Timer tmrLyrics;
        private ToolTip toolTip;
        private Button btnPlay;
        private Button btnPause;
        private Button btnStop;
        private Button btnNext;
        private ToolStrip toolStrip;
        private WinFormsExtendedControls.ToolStripRadioButton tsbtnOrderPlay;
        private WinFormsExtendedControls.ToolStripRadioButton tsbtnShufflePlay;
        private WinFormsExtendedControls.ToolStripRadioButton tsbtnTrackLoop;
        private WinFormsExtendedControls.ToolStripRadioButton tsbtnPlaylistLoop;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbtnAPRepeat;
        private ToolStripButton tsbtnSettings;
        private ToolStripButton tsbtnSoundEffect;
        private Label lblDisplayTitle;
        private PictureBox picAlbum;
        private Label lblTitle;
        private Label lblAlbum;
        private Label lblArtist;
        private Button btnPrevious;
        private Label lblInfo;
        private TableLayoutPanel tableLayoutPanel3;
        private ToolStripButton tsbtnMediaLibraryForm;
        private Label lblPosition;
        private Label lblVolume;
        private TrackBar trbVolume;
        private WinFormsExtendedControls.SelRangeTrackBar trbPosition;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsddbToolbox;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripMenuItem tsmiSupportedFormat;
        private ToolStripMenuItem tsmiCreateDesktopShortcut;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblStatus1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}