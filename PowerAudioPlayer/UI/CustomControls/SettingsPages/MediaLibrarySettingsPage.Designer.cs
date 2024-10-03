namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    partial class MediaLibrarySettingsPage
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
            lvMediaLibraryDirs = new BrightIdeasSoftware.FastObjectListView();
            groupBox1 = new GroupBox();
            btnAddDir = new Button();
            groupBox2 = new GroupBox();
            cbRecordPlayHistroy = new CheckBox();
            btnClearMediaLibrary = new Button();
            btnSaveMediaLibrary = new Button();
            label1 = new Label();
            btnCleanUpMediaLibrary = new Button();
            btnUpdateMediaLibrary = new Button();
            cbMediaLibraryAutoRemove = new CheckBox();
            cbMediaLibraryStartUpRefresh = new CheckBox();
            groupBox3 = new GroupBox();
            cbPlaylistEditorShowFileNameColumn = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)lvMediaLibraryDirs).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lvMediaLibraryDirs
            // 
            lvMediaLibraryDirs.Dock = DockStyle.Top;
            lvMediaLibraryDirs.FullRowSelect = true;
            lvMediaLibraryDirs.GridLines = true;
            lvMediaLibraryDirs.Location = new Point(3, 19);
            lvMediaLibraryDirs.Name = "lvMediaLibraryDirs";
            lvMediaLibraryDirs.ShowGroups = false;
            lvMediaLibraryDirs.Size = new Size(541, 146);
            lvMediaLibraryDirs.TabIndex = 0;
            lvMediaLibraryDirs.View = View.Details;
            lvMediaLibraryDirs.VirtualMode = true;
            lvMediaLibraryDirs.ButtonClick += lvMediaLibraryDirs_ButtonClick;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(btnAddDir);
            groupBox1.Controls.Add(lvMediaLibraryDirs);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 195);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "媒体库目录";
            // 
            // btnAddDir
            // 
            btnAddDir.AutoSize = true;
            btnAddDir.Dock = DockStyle.Top;
            btnAddDir.Location = new Point(3, 165);
            btnAddDir.Name = "btnAddDir";
            btnAddDir.Size = new Size(541, 27);
            btnAddDir.TabIndex = 1;
            btnAddDir.Text = "添加";
            btnAddDir.UseVisualStyleBackColor = true;
            btnAddDir.Click += btnAddDir_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(cbRecordPlayHistroy);
            groupBox2.Controls.Add(btnClearMediaLibrary);
            groupBox2.Controls.Add(btnSaveMediaLibrary);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnCleanUpMediaLibrary);
            groupBox2.Controls.Add(btnUpdateMediaLibrary);
            groupBox2.Controls.Add(cbMediaLibraryAutoRemove);
            groupBox2.Controls.Add(cbMediaLibraryStartUpRefresh);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(547, 210);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "媒体库选项";
            // 
            // cbRecordPlayHistroy
            // 
            cbRecordPlayHistroy.AutoSize = true;
            cbRecordPlayHistroy.Dock = DockStyle.Top;
            cbRecordPlayHistroy.Location = new Point(3, 186);
            cbRecordPlayHistroy.Name = "cbRecordPlayHistroy";
            cbRecordPlayHistroy.Size = new Size(541, 21);
            cbRecordPlayHistroy.TabIndex = 7;
            cbRecordPlayHistroy.Text = "记录播放历史";
            cbRecordPlayHistroy.UseVisualStyleBackColor = true;
            // 
            // btnClearMediaLibrary
            // 
            btnClearMediaLibrary.AutoSize = true;
            btnClearMediaLibrary.Dock = DockStyle.Top;
            btnClearMediaLibrary.Location = new Point(3, 159);
            btnClearMediaLibrary.Name = "btnClearMediaLibrary";
            btnClearMediaLibrary.Size = new Size(541, 27);
            btnClearMediaLibrary.TabIndex = 6;
            btnClearMediaLibrary.Text = "清空媒体库";
            btnClearMediaLibrary.UseVisualStyleBackColor = true;
            btnClearMediaLibrary.Click += btnClearMediaLibrary_Click;
            // 
            // btnSaveMediaLibrary
            // 
            btnSaveMediaLibrary.AutoSize = true;
            btnSaveMediaLibrary.Dock = DockStyle.Top;
            btnSaveMediaLibrary.Location = new Point(3, 132);
            btnSaveMediaLibrary.Name = "btnSaveMediaLibrary";
            btnSaveMediaLibrary.Size = new Size(541, 27);
            btnSaveMediaLibrary.TabIndex = 5;
            btnSaveMediaLibrary.Text = "保存媒体库";
            btnSaveMediaLibrary.UseVisualStyleBackColor = true;
            btnSaveMediaLibrary.Click += btnSaveMediaLibrary_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 115);
            label1.Name = "label1";
            label1.Size = new Size(510, 17);
            label1.TabIndex = 4;
            label1.Text = "只有在程序关闭后媒体库才会被保存到硬盘中。若想立即保存媒体库，点击“保存媒体库”按钮。";
            // 
            // btnCleanUpMediaLibrary
            // 
            btnCleanUpMediaLibrary.AutoSize = true;
            btnCleanUpMediaLibrary.Dock = DockStyle.Top;
            btnCleanUpMediaLibrary.Location = new Point(3, 88);
            btnCleanUpMediaLibrary.Name = "btnCleanUpMediaLibrary";
            btnCleanUpMediaLibrary.Size = new Size(541, 27);
            btnCleanUpMediaLibrary.TabIndex = 3;
            btnCleanUpMediaLibrary.Text = "清理媒体库";
            btnCleanUpMediaLibrary.UseVisualStyleBackColor = true;
            btnCleanUpMediaLibrary.Click += btnCleanUpMediaLibrary_Click;
            // 
            // btnUpdateMediaLibrary
            // 
            btnUpdateMediaLibrary.AutoSize = true;
            btnUpdateMediaLibrary.Dock = DockStyle.Top;
            btnUpdateMediaLibrary.Location = new Point(3, 61);
            btnUpdateMediaLibrary.Name = "btnUpdateMediaLibrary";
            btnUpdateMediaLibrary.Size = new Size(541, 27);
            btnUpdateMediaLibrary.TabIndex = 2;
            btnUpdateMediaLibrary.Text = "更新媒体库";
            btnUpdateMediaLibrary.UseVisualStyleBackColor = true;
            btnUpdateMediaLibrary.Click += btnRefreshMediaLibrary_Click;
            // 
            // cbMediaLibraryAutoRemove
            // 
            cbMediaLibraryAutoRemove.AutoSize = true;
            cbMediaLibraryAutoRemove.Dock = DockStyle.Top;
            cbMediaLibraryAutoRemove.Location = new Point(3, 40);
            cbMediaLibraryAutoRemove.Name = "cbMediaLibraryAutoRemove";
            cbMediaLibraryAutoRemove.Size = new Size(541, 21);
            cbMediaLibraryAutoRemove.TabIndex = 1;
            cbMediaLibraryAutoRemove.Text = "刷新媒体库时，若文件不存在，则删除";
            cbMediaLibraryAutoRemove.UseVisualStyleBackColor = true;
            // 
            // cbMediaLibraryStartUpRefresh
            // 
            cbMediaLibraryStartUpRefresh.AutoSize = true;
            cbMediaLibraryStartUpRefresh.Dock = DockStyle.Top;
            cbMediaLibraryStartUpRefresh.Location = new Point(3, 19);
            cbMediaLibraryStartUpRefresh.Name = "cbMediaLibraryStartUpRefresh";
            cbMediaLibraryStartUpRefresh.Size = new Size(541, 21);
            cbMediaLibraryStartUpRefresh.TabIndex = 0;
            cbMediaLibraryStartUpRefresh.Text = "启动时刷新媒体库";
            cbMediaLibraryStartUpRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(cbPlaylistEditorShowFileNameColumn);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 405);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(547, 43);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "播放列表编辑器";
            // 
            // cbPlaylistEditorShowFileNameColumn
            // 
            cbPlaylistEditorShowFileNameColumn.AutoSize = true;
            cbPlaylistEditorShowFileNameColumn.Dock = DockStyle.Top;
            cbPlaylistEditorShowFileNameColumn.Location = new Point(3, 19);
            cbPlaylistEditorShowFileNameColumn.Name = "cbPlaylistEditorShowFileNameColumn";
            cbPlaylistEditorShowFileNameColumn.Size = new Size(541, 21);
            cbPlaylistEditorShowFileNameColumn.TabIndex = 1;
            cbPlaylistEditorShowFileNameColumn.Text = "*显示“文件名”列";
            cbPlaylistEditorShowFileNameColumn.UseVisualStyleBackColor = true;
            // 
            // MediaLibrarySettingsPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MediaLibrarySettingsPage";
            Size = new Size(547, 458);
            ((System.ComponentModel.ISupportInitialize)lvMediaLibraryDirs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lvMediaLibraryDirs;
        private GroupBox groupBox1;
        private Button btnAddDir;
        private GroupBox groupBox2;
        private CheckBox cbMediaLibraryAutoRemove;
        private CheckBox cbMediaLibraryStartUpRefresh;
        private Button btnCleanUpMediaLibrary;
        private Button btnUpdateMediaLibrary;
        private Button btnSaveMediaLibrary;
        private Label label1;
        private GroupBox groupBox3;
        private CheckBox cbPlaylistEditorShowFileNameColumn;
        private CheckBox cbRecordPlayHistroy;
        private Button btnClearMediaLibrary;
    }
}
