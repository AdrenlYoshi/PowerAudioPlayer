namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    partial class DataSettingsPage
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
            lblMsg = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnExploreFolder = new Button();
            btnExport = new Button();
            btnImport = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Dock = DockStyle.Fill;
            flowLayoutPanel1.SetFlowBreak(lblMsg, true);
            lblMsg.Location = new Point(3, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(34, 17);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "Msg";
            lblMsg.UseMnemonic = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblMsg);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(374, 17);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnExploreFolder
            // 
            btnExploreFolder.Dock = DockStyle.Top;
            btnExploreFolder.Location = new Point(0, 17);
            btnExploreFolder.Name = "btnExploreFolder";
            btnExploreFolder.Size = new Size(374, 23);
            btnExploreFolder.TabIndex = 1;
            btnExploreFolder.Text = "浏览文件夹";
            btnExploreFolder.UseVisualStyleBackColor = true;
            btnExploreFolder.Click += btnExploreFolder_Click;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Top;
            btnExport.Location = new Point(0, 40);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(374, 23);
            btnExport.TabIndex = 2;
            btnExport.Text = "导出数据文件";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Dock = DockStyle.Top;
            btnImport.Location = new Point(0, 63);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(374, 23);
            btnImport.TabIndex = 3;
            btnImport.Text = "导入数据文件";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // DataSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnExploreFolder);
            Controls.Add(flowLayoutPanel1);
            Name = "DataSettingsPage";
            Size = new Size(374, 402);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnExploreFolder;
        private Button btnExport;
        private Button btnImport;
    }
}
