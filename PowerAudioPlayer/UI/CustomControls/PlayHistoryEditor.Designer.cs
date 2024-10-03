namespace PowerAudioPlayer.UI.CustomControls
{
    partial class PlayHistoryEditor
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
            lvHistory = new BrightIdeasSoftware.FastObjectListView();
            contextMenuStrip = new ContextMenuStrip(components);
            tsmiPlay = new ToolStripMenuItem();
            tsmiLineUp = new ToolStripMenuItem();
            tsmiRemove = new ToolStripMenuItem();
            tsmiClear = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiFileInfo = new ToolStripMenuItem();
            tsmiExplorer = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)lvHistory).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lvHistory
            // 
            lvHistory.ContextMenuStrip = contextMenuStrip;
            lvHistory.Dock = DockStyle.Fill;
            lvHistory.FullRowSelect = true;
            lvHistory.GridLines = true;
            lvHistory.Location = new Point(0, 0);
            lvHistory.Name = "lvHistory";
            lvHistory.ShowCommandMenuOnRightClick = true;
            lvHistory.ShowGroups = false;
            lvHistory.Size = new Size(512, 442);
            lvHistory.TabIndex = 0;
            lvHistory.UseFiltering = true;
            lvHistory.View = View.Details;
            lvHistory.VirtualMode = true;
            lvHistory.DoubleClick += lvHistory_DoubleClick;
            lvHistory.KeyDown += lvHistory_KeyDown;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { tsmiPlay, tsmiLineUp, tsmiRemove, tsmiClear, toolStripSeparator1, tsmiFileInfo, tsmiExplorer });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(212, 142);
            // 
            // tsmiPlay
            // 
            tsmiPlay.Name = "tsmiPlay";
            tsmiPlay.Size = new Size(211, 22);
            tsmiPlay.Text = "播放(&P)";
            // 
            // tsmiLineUp
            // 
            tsmiLineUp.Name = "tsmiLineUp";
            tsmiLineUp.Size = new Size(211, 22);
            tsmiLineUp.Text = "排队(&I)";
            tsmiLineUp.Click += tsmiLineUp_Click;
            // 
            // tsmiRemove
            // 
            tsmiRemove.Name = "tsmiRemove";
            tsmiRemove.Size = new Size(211, 22);
            tsmiRemove.Text = "移除(&R)";
            tsmiRemove.Click += tsmiRemove_Click;
            // 
            // tsmiClear
            // 
            tsmiClear.Name = "tsmiClear";
            tsmiClear.Size = new Size(211, 22);
            tsmiClear.Text = "清空(&C)";
            tsmiClear.Click += tsmiClear_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(208, 6);
            // 
            // tsmiFileInfo
            // 
            tsmiFileInfo.Name = "tsmiFileInfo";
            tsmiFileInfo.Size = new Size(211, 22);
            tsmiFileInfo.Text = "查看文件信息(&I)";
            tsmiFileInfo.Click += tsmiFileInfo_Click;
            // 
            // tsmiExplorer
            // 
            tsmiExplorer.Name = "tsmiExplorer";
            tsmiExplorer.Size = new Size(211, 22);
            tsmiExplorer.Text = "在文件资源管理器查看(&E)";
            tsmiExplorer.Click += tsmiExplorer_Click;
            // 
            // PlayHistoryEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvHistory);
            Name = "PlayHistoryEditor";
            Size = new Size(512, 442);
            ((System.ComponentModel.ISupportInitialize)lvHistory).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lvHistory;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem tsmiPlay;
        private ToolStripMenuItem tsmiRemove;
        private ToolStripMenuItem tsmiClear;
        private ToolStripMenuItem tsmiFileInfo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiExplorer;
        private ToolStripMenuItem tsmiLineUp;
    }
}
