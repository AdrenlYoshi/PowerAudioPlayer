namespace PowerAudioPlayer.UI.CustomControls
{
    partial class MediaLibraryEditor
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbFilterKey = new TextBox();
            tbFilterResult = new TextBox();
            lvKeyWord = new BrightIdeasSoftware.FastObjectListView();
            cmsKeyWord = new ContextMenuStrip(components);
            tsmiPlayKeyWord = new ToolStripMenuItem();
            tsmiluKeyWord = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            tsmiKeyWordSendTo = new ToolStripMenuItem();
            tsmiKeyWordSendToPlaylist = new ToolStripMenuItem();
            tsmiKeyWordSendToNewPlaylist = new ToolStripMenuItem();
            lvResult = new BrightIdeasSoftware.FastObjectListView();
            cmsMediaResult = new ContextMenuStrip(components);
            tsmiSelectedCount = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            tsmiMediaPlay = new ToolStripMenuItem();
            tsmiMediaLineUp = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            tsmiMediaSendToPlaylist = new ToolStripMenuItem();
            tsmiMediaSendToNewPlaylist = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripSeparator();
            tsmiMediaRemove = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripSeparator();
            tsmiMediaExplorer = new ToolStripMenuItem();
            tsmiFileInfo = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblTotalCount = new ToolStripStatusLabel();
            lblTotalLength = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            splitContainer3 = new SplitContainer();
            pbAlbumPicture = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblFileName = new Label();
            lblGenre = new Label();
            lblAlbum = new Label();
            lblArtist = new Label();
            lblTitle = new Label();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)lvKeyWord).BeginInit();
            cmsKeyWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lvResult).BeginInit();
            cmsMediaResult.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbumPicture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbFilterKey
            // 
            tbFilterKey.Dock = DockStyle.Top;
            tbFilterKey.Location = new Point(0, 0);
            tbFilterKey.Margin = new Padding(4, 3, 4, 3);
            tbFilterKey.Name = "tbFilterKey";
            tbFilterKey.PlaceholderText = "在此键入搜索关键词";
            tbFilterKey.Size = new Size(175, 23);
            tbFilterKey.TabIndex = 38;
            tbFilterKey.TextChanged += tbFilterKey_TextChanged;
            // 
            // tbFilterResult
            // 
            tbFilterResult.Dock = DockStyle.Top;
            tbFilterResult.Location = new Point(0, 0);
            tbFilterResult.Margin = new Padding(4, 3, 4, 3);
            tbFilterResult.Name = "tbFilterResult";
            tbFilterResult.PlaceholderText = "在此键入搜索关键词";
            tbFilterResult.Size = new Size(464, 23);
            tbFilterResult.TabIndex = 39;
            tbFilterResult.TextChanged += tbFilterResult_TextChanged;
            // 
            // lvKeyWord
            // 
            lvKeyWord.ContextMenuStrip = cmsKeyWord;
            lvKeyWord.Dock = DockStyle.Fill;
            lvKeyWord.FullRowSelect = true;
            lvKeyWord.GridLines = true;
            lvKeyWord.HeaderStyle = ColumnHeaderStyle.None;
            lvKeyWord.Location = new Point(0, 23);
            lvKeyWord.Margin = new Padding(4, 3, 4, 3);
            lvKeyWord.MultiSelect = false;
            lvKeyWord.Name = "lvKeyWord";
            lvKeyWord.ShowGroups = false;
            lvKeyWord.Size = new Size(175, 396);
            lvKeyWord.TabIndex = 35;
            lvKeyWord.UseFiltering = true;
            lvKeyWord.View = View.Details;
            lvKeyWord.VirtualMode = true;
            lvKeyWord.SelectedIndexChanged += lvKeyWord_SelectedIndexChanged;
            // 
            // cmsKeyWord
            // 
            cmsKeyWord.Items.AddRange(new ToolStripItem[] { tsmiPlayKeyWord, tsmiluKeyWord, toolStripMenuItem3, tsmiKeyWordSendTo });
            cmsKeyWord.Name = "cmsMediaResult";
            cmsKeyWord.Size = new Size(116, 76);
            cmsKeyWord.Opening += cmsKeyWord_Opening;
            // 
            // tsmiPlayKeyWord
            // 
            tsmiPlayKeyWord.Name = "tsmiPlayKeyWord";
            tsmiPlayKeyWord.Size = new Size(115, 22);
            tsmiPlayKeyWord.Text = "播放(&P)";
            tsmiPlayKeyWord.Click += tsmiPlayKeyWord_Click;
            // 
            // tsmiluKeyWord
            // 
            tsmiluKeyWord.Name = "tsmiluKeyWord";
            tsmiluKeyWord.Size = new Size(115, 22);
            tsmiluKeyWord.Text = "排队(&L)";
            tsmiluKeyWord.Click += tsmiluKeyWord_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(112, 6);
            // 
            // tsmiKeyWordSendTo
            // 
            tsmiKeyWordSendTo.DropDownItems.AddRange(new ToolStripItem[] { tsmiKeyWordSendToPlaylist, tsmiKeyWordSendToNewPlaylist });
            tsmiKeyWordSendTo.Name = "tsmiKeyWordSendTo";
            tsmiKeyWordSendTo.Size = new Size(115, 22);
            tsmiKeyWordSendTo.Text = "发送到";
            // 
            // tsmiKeyWordSendToPlaylist
            // 
            tsmiKeyWordSendToPlaylist.Name = "tsmiKeyWordSendToPlaylist";
            tsmiKeyWordSendToPlaylist.Size = new Size(164, 22);
            tsmiKeyWordSendToPlaylist.Text = "现有播放列表(&C)";
            // 
            // tsmiKeyWordSendToNewPlaylist
            // 
            tsmiKeyWordSendToNewPlaylist.Name = "tsmiKeyWordSendToNewPlaylist";
            tsmiKeyWordSendToNewPlaylist.Size = new Size(164, 22);
            tsmiKeyWordSendToNewPlaylist.Text = "新播放列表(&N)";
            tsmiKeyWordSendToNewPlaylist.Click += tsmiKeyWordSendToNewPlaylist_Click;
            // 
            // lvResult
            // 
            lvResult.ContextMenuStrip = cmsMediaResult;
            lvResult.Dock = DockStyle.Fill;
            lvResult.FullRowSelect = true;
            lvResult.GridLines = true;
            lvResult.Location = new Point(0, 0);
            lvResult.Margin = new Padding(4, 3, 4, 3);
            lvResult.Name = "lvResult";
            lvResult.ShowCommandMenuOnRightClick = true;
            lvResult.ShowGroups = false;
            lvResult.Size = new Size(464, 290);
            lvResult.TabIndex = 36;
            lvResult.UseFiltering = true;
            lvResult.View = View.Details;
            lvResult.VirtualMode = true;
            lvResult.SelectedIndexChanged += lvResult_SelectedIndexChanged;
            lvResult.DoubleClick += lvResult_DoubleClick;
            // 
            // cmsMediaResult
            // 
            cmsMediaResult.Items.AddRange(new ToolStripItem[] { tsmiSelectedCount, toolStripMenuItem4, tsmiMediaPlay, tsmiMediaLineUp, toolStripMenuItem7, toolStripMenuItem10, tsmiMediaRemove, toolStripMenuItem11, tsmiMediaExplorer, tsmiFileInfo });
            cmsMediaResult.Name = "cmsMediaResult";
            cmsMediaResult.Size = new Size(212, 176);
            cmsMediaResult.Opening += cmsMediaResult_Opening;
            // 
            // tsmiSelectedCount
            // 
            tsmiSelectedCount.Enabled = false;
            tsmiSelectedCount.Name = "tsmiSelectedCount";
            tsmiSelectedCount.Size = new Size(211, 22);
            tsmiSelectedCount.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(208, 6);
            // 
            // tsmiMediaPlay
            // 
            tsmiMediaPlay.Name = "tsmiMediaPlay";
            tsmiMediaPlay.Size = new Size(211, 22);
            tsmiMediaPlay.Text = "播放(&P)";
            tsmiMediaPlay.Click += tsmiMediaPlay_Click;
            // 
            // tsmiMediaLineUp
            // 
            tsmiMediaLineUp.Name = "tsmiMediaLineUp";
            tsmiMediaLineUp.Size = new Size(211, 22);
            tsmiMediaLineUp.Text = "排队(&L)";
            tsmiMediaLineUp.Click += tsmiMediaLineUp_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { tsmiMediaSendToPlaylist, tsmiMediaSendToNewPlaylist });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(211, 22);
            toolStripMenuItem7.Text = "发送到";
            // 
            // tsmiMediaSendToPlaylist
            // 
            tsmiMediaSendToPlaylist.Name = "tsmiMediaSendToPlaylist";
            tsmiMediaSendToPlaylist.Size = new Size(164, 22);
            tsmiMediaSendToPlaylist.Text = "现有播放列表(&C)";
            // 
            // tsmiMediaSendToNewPlaylist
            // 
            tsmiMediaSendToNewPlaylist.Name = "tsmiMediaSendToNewPlaylist";
            tsmiMediaSendToNewPlaylist.Size = new Size(164, 22);
            tsmiMediaSendToNewPlaylist.Text = "新播放列表(&N)";
            tsmiMediaSendToNewPlaylist.Click += tsmiMediaSendToNewPlaylist_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(208, 6);
            // 
            // tsmiMediaRemove
            // 
            tsmiMediaRemove.Name = "tsmiMediaRemove";
            tsmiMediaRemove.Size = new Size(211, 22);
            tsmiMediaRemove.Text = "移除(&R)";
            tsmiMediaRemove.Click += tsmiMediaRemove_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(208, 6);
            // 
            // tsmiMediaExplorer
            // 
            tsmiMediaExplorer.Name = "tsmiMediaExplorer";
            tsmiMediaExplorer.Size = new Size(211, 22);
            tsmiMediaExplorer.Text = "在文件资源管理器查看(&E)";
            tsmiMediaExplorer.Click += tsmiMediaExplorer_Click;
            // 
            // tsmiFileInfo
            // 
            tsmiFileInfo.Name = "tsmiFileInfo";
            tsmiFileInfo.Size = new Size(211, 22);
            tsmiFileInfo.Text = "查看文件信息(&I)";
            tsmiFileInfo.Click += tsmiFileInfo_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTotalCount, lblTotalLength, lblStatus });
            statusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip.Location = new Point(0, 419);
            statusStrip.Name = "statusStrip";
            statusStrip.ShowItemToolTips = true;
            statusStrip.Size = new Size(643, 26);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 37;
            statusStrip.Text = "statusStrip";
            // 
            // lblTotalCount
            // 
            lblTotalCount.Font = new Font("Microsoft YaHei UI", 9F);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(15, 21);
            lblTotalCount.Text = "0";
            // 
            // lblTotalLength
            // 
            lblTotalLength.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTotalLength.Font = new Font("Microsoft YaHei UI", 9F);
            lblTotalLength.Name = "lblTotalLength";
            lblTotalLength.Size = new Size(43, 21);
            lblTotalLength.Text = "00:00";
            // 
            // lblStatus
            // 
            lblStatus.Alignment = ToolStripItemAlignment.Right;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(113, 21);
            lblStatus.Text = "PowerAudioPlayer";
            lblStatus.Visible = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lvKeyWord);
            splitContainer1.Panel1.Controls.Add(tbFilterKey);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(tbFilterResult);
            splitContainer1.Size = new Size(643, 419);
            splitContainer1.SplitterDistance = 175;
            splitContainer1.TabIndex = 40;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Location = new Point(0, 23);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lvResult);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.AutoScroll = true;
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(464, 396);
            splitContainer2.SplitterDistance = 290;
            splitContainer2.TabIndex = 40;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(464, 102);
            label1.TabIndex = 1;
            label1.Text = "选择一个项目以查看文件信息";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(pbAlbumPicture);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.AutoScroll = true;
            splitContainer3.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer3.Size = new Size(464, 102);
            splitContainer3.SplitterDistance = 111;
            splitContainer3.TabIndex = 0;
            // 
            // pbAlbumPicture
            // 
            pbAlbumPicture.BackgroundImageLayout = ImageLayout.None;
            pbAlbumPicture.BorderStyle = BorderStyle.FixedSingle;
            pbAlbumPicture.Dock = DockStyle.Fill;
            pbAlbumPicture.Location = new Point(0, 0);
            pbAlbumPicture.Name = "pbAlbumPicture";
            pbAlbumPicture.Size = new Size(111, 102);
            pbAlbumPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlbumPicture.TabIndex = 0;
            pbAlbumPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblFileName, 0, 4);
            tableLayoutPanel1.Controls.Add(lblGenre, 0, 3);
            tableLayoutPanel1.Controls.Add(lblAlbum, 0, 2);
            tableLayoutPanel1.Controls.Add(lblArtist, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(17, 91);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(4, 73);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(0, 17);
            lblFileName.TabIndex = 5;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(4, 55);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(0, 17);
            lblGenre.TabIndex = 4;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(4, 37);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(0, 17);
            lblAlbum.TabIndex = 3;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(4, 19);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(0, 17);
            lblArtist.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(4, 1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 17);
            lblTitle.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // MediaLibraryEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip);
            Name = "MediaLibraryEditor";
            Size = new Size(643, 445);
            ((System.ComponentModel.ISupportInitialize)lvKeyWord).EndInit();
            cmsKeyWord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lvResult).EndInit();
            cmsMediaResult.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAlbumPicture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFilterKey;
        private TextBox tbFilterResult;
        private BrightIdeasSoftware.FastObjectListView lvKeyWord;
        private ContextMenuStrip cmsKeyWord;
        private ToolStripMenuItem tsmiPlayKeyWord;
        private ToolStripMenuItem tsmiluKeyWord;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem tsmiKeyWordSendTo;
        private ToolStripMenuItem tsmiKeyWordSendToPlaylist;
        private ToolStripMenuItem tsmiKeyWordSendToNewPlaylist;
        private BrightIdeasSoftware.FastObjectListView lvResult;
        private ContextMenuStrip cmsMediaResult;
        private ToolStripMenuItem tsmiSelectedCount;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem tsmiMediaPlay;
        private ToolStripMenuItem tsmiMediaLineUp;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem tsmiMediaSendToPlaylist;
        private ToolStripMenuItem tsmiMediaSendToNewPlaylist;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripMenuItem tsmiMediaRemove;
        private ToolStripSeparator toolStripMenuItem11;
        private ToolStripMenuItem tsmiMediaExplorer;
        private ToolStripMenuItem tsmiFileInfo;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTotalCount;
        private ToolStripStatusLabel lblTotalLength;
        private ToolStripStatusLabel lblStatus;
        private SplitContainer splitContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbAlbumPicture;
        private Label lblFileName;
        private Label lblGenre;
        private Label lblAlbum;
        private Label lblArtist;
        private Label lblTitle;
        private SplitContainer splitContainer3;
        private Label label1;
    }
}
