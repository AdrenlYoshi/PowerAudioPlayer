namespace PowerAudioPlayer.UI.CustomControls
{
    partial class LyricsView
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
            surface = new SkiaSharp.Views.Desktop.SKControl();
            contextMenuStrip = new ContextMenuStrip(components);
            复制当前歌词CToolStripMenuItem = new ToolStripMenuItem();
            复制全部歌词AToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // surface
            // 
            surface.ContextMenuStrip = contextMenuStrip;
            surface.Dock = DockStyle.Fill;
            surface.Location = new Point(0, 0);
            surface.Name = "surface";
            surface.Size = new Size(496, 418);
            surface.TabIndex = 0;
            surface.Text = "skControl1";
            surface.PaintSurface += surface_PaintSurface;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { 复制当前歌词CToolStripMenuItem, 复制全部歌词AToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(181, 70);
            // 
            // 复制当前歌词CToolStripMenuItem
            // 
            复制当前歌词CToolStripMenuItem.Name = "复制当前歌词CToolStripMenuItem";
            复制当前歌词CToolStripMenuItem.Size = new Size(180, 22);
            复制当前歌词CToolStripMenuItem.Text = "复制当前歌词(&C)";
            // 
            // 复制全部歌词AToolStripMenuItem
            // 
            复制全部歌词AToolStripMenuItem.Name = "复制全部歌词AToolStripMenuItem";
            复制全部歌词AToolStripMenuItem.Size = new Size(180, 22);
            复制全部歌词AToolStripMenuItem.Text = "复制全部歌词(&A)";
            // 
            // LyricsView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(surface);
            Name = "LyricsView";
            Size = new Size(496, 418);
            SizeChanged += LyricsView_SizeChanged;
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SkiaSharp.Views.Desktop.SKControl surface;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem 复制当前歌词CToolStripMenuItem;
        private ToolStripMenuItem 复制全部歌词AToolStripMenuItem;
    }
}
