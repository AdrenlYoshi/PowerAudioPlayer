namespace PowerAudioPlayer.UI
{
    partial class InformationForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbFileName = new TextBox();
            tbSize = new TextBox();
            tbLength = new TextBox();
            tbType = new TextBox();
            tbBitrate = new TextBox();
            tbSamplerate = new TextBox();
            tbChannel = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            llblView = new LinkLabel();
            tbPath = new TextBox();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label13 = new Label();
            label16 = new Label();
            label10 = new Label();
            label17 = new Label();
            label9 = new Label();
            label14 = new Label();
            label15 = new Label();
            label11 = new Label();
            label12 = new Label();
            label18 = new Label();
            tbArtist = new TextBox();
            tbAlbum = new TextBox();
            tbTitle = new TextBox();
            tbTrack = new TextBox();
            tbDisc = new TextBox();
            tbYear = new TextBox();
            tbGenre = new TextBox();
            tbCopyright = new TextBox();
            tbComment = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblImage = new Label();
            pictureBox = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(30, 3, 3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(314, 550);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(306, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "基本";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(tbFileName, 1, 0);
            tableLayoutPanel1.Controls.Add(tbSize, 1, 2);
            tableLayoutPanel1.Controls.Add(tbLength, 1, 3);
            tableLayoutPanel1.Controls.Add(tbType, 1, 4);
            tableLayoutPanel1.Controls.Add(tbBitrate, 1, 5);
            tableLayoutPanel1.Controls.Add(tbSamplerate, 1, 6);
            tableLayoutPanel1.Controls.Add(tbChannel, 1, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(300, 514);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 215);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 13;
            label8.Text = "声道数";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "文件名";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 186);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 11;
            label7.Text = "采样率";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "完整路径";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 157);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 9;
            label6.Text = "比特率";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 3;
            label3.Text = "文件大小";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 128);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 7;
            label5.Text = "类型";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 5;
            label4.Text = "长度";
            // 
            // tbFileName
            // 
            tbFileName.Dock = DockStyle.Fill;
            tbFileName.Location = new Point(65, 3);
            tbFileName.Name = "tbFileName";
            tbFileName.ReadOnly = true;
            tbFileName.Size = new Size(232, 23);
            tbFileName.TabIndex = 1;
            tbFileName.WordWrap = false;
            // 
            // tbSize
            // 
            tbSize.Dock = DockStyle.Fill;
            tbSize.Location = new Point(65, 67);
            tbSize.Name = "tbSize";
            tbSize.ReadOnly = true;
            tbSize.Size = new Size(232, 23);
            tbSize.TabIndex = 4;
            tbSize.WordWrap = false;
            // 
            // tbLength
            // 
            tbLength.Dock = DockStyle.Fill;
            tbLength.Location = new Point(65, 96);
            tbLength.Name = "tbLength";
            tbLength.ReadOnly = true;
            tbLength.Size = new Size(232, 23);
            tbLength.TabIndex = 6;
            tbLength.WordWrap = false;
            // 
            // tbType
            // 
            tbType.Dock = DockStyle.Fill;
            tbType.Location = new Point(65, 125);
            tbType.Name = "tbType";
            tbType.ReadOnly = true;
            tbType.Size = new Size(232, 23);
            tbType.TabIndex = 8;
            tbType.WordWrap = false;
            // 
            // tbBitrate
            // 
            tbBitrate.Dock = DockStyle.Fill;
            tbBitrate.Location = new Point(65, 154);
            tbBitrate.Name = "tbBitrate";
            tbBitrate.ReadOnly = true;
            tbBitrate.Size = new Size(232, 23);
            tbBitrate.TabIndex = 10;
            tbBitrate.WordWrap = false;
            // 
            // tbSamplerate
            // 
            tbSamplerate.Dock = DockStyle.Fill;
            tbSamplerate.Location = new Point(65, 183);
            tbSamplerate.Name = "tbSamplerate";
            tbSamplerate.ReadOnly = true;
            tbSamplerate.Size = new Size(232, 23);
            tbSamplerate.TabIndex = 12;
            tbSamplerate.WordWrap = false;
            // 
            // tbChannel
            // 
            tbChannel.Dock = DockStyle.Fill;
            tbChannel.Location = new Point(65, 212);
            tbChannel.Name = "tbChannel";
            tbChannel.ReadOnly = true;
            tbChannel.Size = new Size(232, 23);
            tbChannel.TabIndex = 14;
            tbChannel.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(llblView, 1, 0);
            tableLayoutPanel2.Controls.Add(tbPath, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(65, 32);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(232, 29);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // llblView
            // 
            llblView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            llblView.AutoSize = true;
            llblView.Location = new Point(197, 6);
            llblView.Name = "llblView";
            llblView.Size = new Size(32, 17);
            llblView.TabIndex = 1;
            llblView.TabStop = true;
            llblView.Text = "查看";
            llblView.LinkClicked += llblView_LinkClicked;
            // 
            // tbPath
            // 
            tbPath.Dock = DockStyle.Fill;
            tbPath.Location = new Point(3, 3);
            tbPath.Name = "tbPath";
            tbPath.ReadOnly = true;
            tbPath.Size = new Size(188, 23);
            tbPath.TabIndex = 0;
            tbPath.WordWrap = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(306, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "标签";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label13, 0, 5);
            tableLayoutPanel3.Controls.Add(label16, 0, 4);
            tableLayoutPanel3.Controls.Add(label10, 0, 6);
            tableLayoutPanel3.Controls.Add(label17, 0, 3);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(label14, 0, 1);
            tableLayoutPanel3.Controls.Add(label15, 0, 2);
            tableLayoutPanel3.Controls.Add(label11, 0, 7);
            tableLayoutPanel3.Controls.Add(label12, 0, 8);
            tableLayoutPanel3.Controls.Add(label18, 0, 9);
            tableLayoutPanel3.Controls.Add(tbArtist, 1, 0);
            tableLayoutPanel3.Controls.Add(tbAlbum, 1, 1);
            tableLayoutPanel3.Controls.Add(tbTitle, 1, 2);
            tableLayoutPanel3.Controls.Add(tbTrack, 1, 3);
            tableLayoutPanel3.Controls.Add(tbDisc, 1, 4);
            tableLayoutPanel3.Controls.Add(tbYear, 1, 5);
            tableLayoutPanel3.Controls.Add(tbGenre, 1, 6);
            tableLayoutPanel3.Controls.Add(tbCopyright, 1, 7);
            tableLayoutPanel3.Controls.Add(tbComment, 1, 8);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 9);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(300, 514);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(3, 151);
            label13.Name = "label13";
            label13.Size = new Size(44, 17);
            label13.TabIndex = 10;
            label13.Text = "年份";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(3, 122);
            label16.Name = "label16";
            label16.Size = new Size(44, 17);
            label16.TabIndex = 8;
            label16.Text = "唱片";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(3, 180);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 12;
            label10.Text = "流派";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(3, 93);
            label17.Name = "label17";
            label17.Size = new Size(44, 17);
            label17.TabIndex = 6;
            label17.Text = "音轨号";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 6);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 0;
            label9.Text = "艺术家";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(3, 35);
            label14.Name = "label14";
            label14.Size = new Size(44, 17);
            label14.TabIndex = 2;
            label14.Text = "专辑";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(3, 64);
            label15.Name = "label15";
            label15.Size = new Size(44, 17);
            label15.TabIndex = 4;
            label15.Text = "标题";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(3, 209);
            label11.Name = "label11";
            label11.Size = new Size(44, 17);
            label11.TabIndex = 14;
            label11.Text = "版权";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(3, 238);
            label12.Name = "label12";
            label12.Size = new Size(44, 17);
            label12.TabIndex = 16;
            label12.Text = "注释";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Location = new Point(3, 379);
            label18.Name = "label18";
            label18.Size = new Size(44, 17);
            label18.TabIndex = 18;
            label18.Text = "图片";
            // 
            // tbArtist
            // 
            tbArtist.Dock = DockStyle.Fill;
            tbArtist.Location = new Point(53, 3);
            tbArtist.Multiline = true;
            tbArtist.Name = "tbArtist";
            tbArtist.ReadOnly = true;
            tbArtist.ScrollBars = ScrollBars.Vertical;
            tbArtist.Size = new Size(244, 23);
            tbArtist.TabIndex = 1;
            // 
            // tbAlbum
            // 
            tbAlbum.Dock = DockStyle.Fill;
            tbAlbum.Location = new Point(53, 32);
            tbAlbum.Multiline = true;
            tbAlbum.Name = "tbAlbum";
            tbAlbum.ReadOnly = true;
            tbAlbum.ScrollBars = ScrollBars.Vertical;
            tbAlbum.Size = new Size(244, 23);
            tbAlbum.TabIndex = 3;
            // 
            // tbTitle
            // 
            tbTitle.Dock = DockStyle.Fill;
            tbTitle.Location = new Point(53, 61);
            tbTitle.Multiline = true;
            tbTitle.Name = "tbTitle";
            tbTitle.ReadOnly = true;
            tbTitle.ScrollBars = ScrollBars.Vertical;
            tbTitle.Size = new Size(244, 23);
            tbTitle.TabIndex = 5;
            // 
            // tbTrack
            // 
            tbTrack.Dock = DockStyle.Fill;
            tbTrack.Location = new Point(53, 90);
            tbTrack.Multiline = true;
            tbTrack.Name = "tbTrack";
            tbTrack.ReadOnly = true;
            tbTrack.ScrollBars = ScrollBars.Vertical;
            tbTrack.Size = new Size(244, 23);
            tbTrack.TabIndex = 7;
            // 
            // tbDisc
            // 
            tbDisc.Dock = DockStyle.Fill;
            tbDisc.Location = new Point(53, 119);
            tbDisc.Multiline = true;
            tbDisc.Name = "tbDisc";
            tbDisc.ReadOnly = true;
            tbDisc.ScrollBars = ScrollBars.Vertical;
            tbDisc.Size = new Size(244, 23);
            tbDisc.TabIndex = 9;
            // 
            // tbYear
            // 
            tbYear.Dock = DockStyle.Fill;
            tbYear.Location = new Point(53, 148);
            tbYear.Multiline = true;
            tbYear.Name = "tbYear";
            tbYear.ReadOnly = true;
            tbYear.ScrollBars = ScrollBars.Vertical;
            tbYear.Size = new Size(244, 23);
            tbYear.TabIndex = 11;
            // 
            // tbGenre
            // 
            tbGenre.Dock = DockStyle.Fill;
            tbGenre.Location = new Point(53, 177);
            tbGenre.Multiline = true;
            tbGenre.Name = "tbGenre";
            tbGenre.ReadOnly = true;
            tbGenre.ScrollBars = ScrollBars.Vertical;
            tbGenre.Size = new Size(244, 23);
            tbGenre.TabIndex = 13;
            // 
            // tbCopyright
            // 
            tbCopyright.Dock = DockStyle.Fill;
            tbCopyright.Location = new Point(53, 206);
            tbCopyright.Multiline = true;
            tbCopyright.Name = "tbCopyright";
            tbCopyright.ReadOnly = true;
            tbCopyright.ScrollBars = ScrollBars.Vertical;
            tbCopyright.Size = new Size(244, 23);
            tbCopyright.TabIndex = 15;
            // 
            // tbComment
            // 
            tbComment.Dock = DockStyle.Fill;
            tbComment.Location = new Point(53, 235);
            tbComment.Multiline = true;
            tbComment.Name = "tbComment";
            tbComment.ReadOnly = true;
            tbComment.ScrollBars = ScrollBars.Vertical;
            tbComment.Size = new Size(244, 23);
            tbComment.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(lblImage, 0, 1);
            tableLayoutPanel4.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(53, 264);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(244, 247);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(3, 230);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(0, 17);
            lblImage.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(238, 224);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.DoubleClick += pictureBox_DoubleClick;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(314, 550);
            Controls.Add(tabControl1);
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InformationForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "文件信息";
            HelpButtonClicked += InformationForm_HelpButtonClicked;
            Load += InformationForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbFileName;
        private TextBox tbPath;
        private TextBox tbSize;
        private TextBox tbLength;
        private TextBox tbType;
        private TextBox tbBitrate;
        private TextBox tbSamplerate;
        private TextBox tbChannel;
        private TableLayoutPanel tableLayoutPanel2;
        private LinkLabel llblView;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label18;
        private TextBox tbArtist;
        private TextBox tbAlbum;
        private TextBox tbTitle;
        private TextBox tbTrack;
        private TextBox tbDisc;
        private TextBox tbYear;
        private TextBox tbGenre;
        private TextBox tbCopyright;
        private TextBox tbComment;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblImage;
        private PictureBox pictureBox;
    }
}