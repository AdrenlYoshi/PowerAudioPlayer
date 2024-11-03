namespace PowerAudioPlayer.UI
{
    partial class MediaLibraryForm
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
            TreeNode treeNode1 = new TreeNode("艺术家");
            TreeNode treeNode2 = new TreeNode("专辑");
            TreeNode treeNode3 = new TreeNode("流派");
            TreeNode treeNode4 = new TreeNode("文件类型");
            TreeNode treeNode5 = new TreeNode("文件夹");
            TreeNode treeNode6 = new TreeNode("媒体", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("播放列表");
            TreeNode treeNode8 = new TreeNode("播放历史");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaLibraryForm));
            cmsPlaylist = new ContextMenuStrip(components);
            tsmiNewPlaylist = new ToolStripMenuItem();
            tsmiImportActivePlaylist = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            tvTreeView = new TreeView();
            lblWelcome = new Label();
            mediaLibraryEditor = new CustomControls.MediaLibraryEditor();
            playlistEditor = new CustomControls.PlaylistEditor();
            playHistoryEditor = new CustomControls.PlayHistoryEditor();
            cmsPlaylistNode = new ContextMenuStrip(components);
            tsmiRenamePlaylist = new ToolStripMenuItem();
            tsmiRemovePlaylist = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tsmiPlayPlaylist = new ToolStripMenuItem();
            tsmiLineUpPlaylist = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            tsmiSendPlToMediaLibrary = new ToolStripMenuItem();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            cmsPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            cmsPlaylistNode.SuspendLayout();
            SuspendLayout();
            // 
            // cmsPlaylist
            // 
            cmsPlaylist.Items.AddRange(new ToolStripItem[] { tsmiNewPlaylist, tsmiImportActivePlaylist });
            cmsPlaylist.Name = "cmsPlaylist";
            cmsPlaylist.Size = new Size(197, 48);
            // 
            // tsmiNewPlaylist
            // 
            tsmiNewPlaylist.Name = "tsmiNewPlaylist";
            tsmiNewPlaylist.Size = new Size(196, 22);
            tsmiNewPlaylist.Text = "新建播放列表(&N)";
            tsmiNewPlaylist.Click += tsmiNewPlaylist_Click;
            // 
            // tsmiImportActivePlaylist
            // 
            tsmiImportActivePlaylist.Name = "tsmiImportActivePlaylist";
            tsmiImportActivePlaylist.Size = new Size(196, 22);
            tsmiImportActivePlaylist.Text = "导入活动的播放列表(&I)";
            tsmiImportActivePlaylist.Click += tsmiImportActivePlaylist_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvTreeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblWelcome);
            splitContainer1.Panel2.Controls.Add(mediaLibraryEditor);
            splitContainer1.Panel2.Controls.Add(playlistEditor);
            splitContainer1.Panel2.Controls.Add(playHistoryEditor);
            splitContainer1.Size = new Size(816, 424);
            splitContainer1.SplitterDistance = 159;
            splitContainer1.TabIndex = 1;
            // 
            // tvTreeView
            // 
            tvTreeView.Dock = DockStyle.Fill;
            tvTreeView.Indent = 19;
            tvTreeView.Location = new Point(0, 0);
            tvTreeView.Margin = new Padding(4, 3, 4, 3);
            tvTreeView.Name = "tvTreeView";
            treeNode1.Name = "nodeArtist";
            treeNode1.Tag = "Artist";
            treeNode1.Text = "艺术家";
            treeNode2.Name = "nodeAlbum";
            treeNode2.Tag = "Album";
            treeNode2.Text = "专辑";
            treeNode3.Name = "nodeGenre";
            treeNode3.Tag = "Genre";
            treeNode3.Text = "流派";
            treeNode4.Name = "nodeFileType";
            treeNode4.Tag = "FileType";
            treeNode4.Text = "文件类型";
            treeNode5.Name = "nodeFolder";
            treeNode5.Tag = "Folder";
            treeNode5.Text = "文件夹";
            treeNode6.Name = "nodeMedia";
            treeNode6.Text = "媒体";
            treeNode7.ContextMenuStrip = cmsPlaylist;
            treeNode7.Name = "nodePlaylist";
            treeNode7.Text = "播放列表";
            treeNode8.Name = "nodePlayHistory";
            treeNode8.Text = "播放历史";
            tvTreeView.Nodes.AddRange(new TreeNode[] { treeNode6, treeNode7, treeNode8 });
            tvTreeView.Size = new Size(159, 424);
            tvTreeView.TabIndex = 0;
            tvTreeView.NodeMouseClick += tvTreeView_NodeMouseClick;
            tvTreeView.KeyDown += tvTreeView_KeyDown;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(653, 424);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "PowerAudioPlayer";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mediaLibraryEditor
            // 
            mediaLibraryEditor.Dock = DockStyle.Fill;
            mediaLibraryEditor.Location = new Point(0, 0);
            mediaLibraryEditor.Name = "mediaLibraryEditor";
            mediaLibraryEditor.Size = new Size(653, 424);
            mediaLibraryEditor.TabIndex = 0;
            mediaLibraryEditor.PlayItem += mediaLibraryEditor_PlayItem;
            mediaLibraryEditor.LineUpItem += mediaLibraryEditor_LineUpItem;
            mediaLibraryEditor.PlayKeyWord += mediaLibraryEditor_PlayKeyWord;
            mediaLibraryEditor.LineUpKeyWord += mediaLibraryEditor_LineUpKeyWord;
            mediaLibraryEditor.SendToNewPlaylistKeyWord += mediaLibraryEditor_SendToNewPlaylistKeyWord;
            mediaLibraryEditor.SendToNewPlaylistItem += mediaLibraryEditor_SendToNewPlaylistItem;
            // 
            // playlistEditor
            // 
            playlistEditor.AllowDrop = true;
            playlistEditor.Dock = DockStyle.Fill;
            playlistEditor.Location = new Point(0, 0);
            playlistEditor.Margin = new Padding(4, 3, 4, 3);
            playlistEditor.Name = "playlistEditor";
            playlistEditor.Size = new Size(653, 424);
            playlistEditor.TabIndex = 0;
            playlistEditor.PlayItem += playlistEditor_PlayItem;
            playlistEditor.LineUpItem += playlistEditor_LineUpItem;
            // 
            // playHistoryEditor
            // 
            playHistoryEditor.Dock = DockStyle.Fill;
            playHistoryEditor.Location = new Point(0, 0);
            playHistoryEditor.Name = "playHistoryEditor";
            playHistoryEditor.Size = new Size(653, 424);
            playHistoryEditor.TabIndex = 2;
            playHistoryEditor.PlayItem += playHistoryEditor_PlayItem;
            playHistoryEditor.LineUpItem += playHistoryEditor_LineUpItem;
            // 
            // cmsPlaylistNode
            // 
            cmsPlaylistNode.Items.AddRange(new ToolStripItem[] { tsmiRenamePlaylist, tsmiRemovePlaylist, toolStripMenuItem1, tsmiPlayPlaylist, tsmiLineUpPlaylist, toolStripMenuItem2, tsmiSendPlToMediaLibrary });
            cmsPlaylistNode.Name = "cmsPlaylist";
            cmsPlaylistNode.Size = new Size(149, 126);
            // 
            // tsmiRenamePlaylist
            // 
            tsmiRenamePlaylist.Name = "tsmiRenamePlaylist";
            tsmiRenamePlaylist.Size = new Size(148, 22);
            tsmiRenamePlaylist.Text = "重命名(&R)";
            tsmiRenamePlaylist.Click += tsmiRenamePlaylist_Click;
            // 
            // tsmiRemovePlaylist
            // 
            tsmiRemovePlaylist.Name = "tsmiRemovePlaylist";
            tsmiRemovePlaylist.Size = new Size(148, 22);
            tsmiRemovePlaylist.Text = "删除(&E)";
            tsmiRemovePlaylist.Click += tsmiRemovePlaylist_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(145, 6);
            // 
            // tsmiPlayPlaylist
            // 
            tsmiPlayPlaylist.Name = "tsmiPlayPlaylist";
            tsmiPlayPlaylist.Size = new Size(148, 22);
            tsmiPlayPlaylist.Text = "播放(&P)";
            tsmiPlayPlaylist.Click += tsmiPlayPlaylist_Click;
            // 
            // tsmiLineUpPlaylist
            // 
            tsmiLineUpPlaylist.Name = "tsmiLineUpPlaylist";
            tsmiLineUpPlaylist.Size = new Size(148, 22);
            tsmiLineUpPlaylist.Text = "排队(&L)";
            tsmiLineUpPlaylist.Click += tsmiLineUpPlaylist_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(145, 6);
            // 
            // tsmiSendPlToMediaLibrary
            // 
            tsmiSendPlToMediaLibrary.Name = "tsmiSendPlToMediaLibrary";
            tsmiSendPlToMediaLibrary.Size = new Size(148, 22);
            tsmiSendPlToMediaLibrary.Text = "发送到媒体库";
            tsmiSendPlToMediaLibrary.Click += tsmiSendPlToMediaLibrary_Click;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // MediaLibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 424);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MediaLibraryForm";
            ShowInTaskbar = false;
            Text = "媒体库";
            FormClosing += MediaLibraryForm_FormClosing;
            cmsPlaylist.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            cmsPlaylistNode.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private TreeView tvTreeView;
        private Label lblWelcome;
        private CustomControls.PlaylistEditor playlistEditor;
        private ContextMenuStrip cmsPlaylist;
        private ToolStripMenuItem tsmiNewPlaylist;
        private ToolStripMenuItem tsmiImportActivePlaylist;
        private ContextMenuStrip cmsPlaylistNode;
        private ToolStripMenuItem tsmiRemovePlaylist;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiPlayPlaylist;
        private ToolStripMenuItem tsmiLineUpPlaylist;
        private ToolStripMenuItem tsmiRenamePlaylist;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem tsmiSendPlToMediaLibrary;
        private CustomControls.MediaLibraryEditor mediaLibraryEditor;
        private CustomControls.PlayHistoryEditor playHistoryEditor;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}