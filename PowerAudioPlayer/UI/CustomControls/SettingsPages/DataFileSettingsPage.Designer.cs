namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    partial class DataFileSettingsPage
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
            btnClearCurrentUser = new Button();
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
            btnExploreFolder.AutoSize = true;
            btnExploreFolder.Dock = DockStyle.Top;
            btnExploreFolder.Location = new Point(0, 17);
            btnExploreFolder.Name = "btnExploreFolder";
            btnExploreFolder.Size = new Size(374, 27);
            btnExploreFolder.TabIndex = 1;
            btnExploreFolder.Text = "浏览文件夹";
            btnExploreFolder.UseVisualStyleBackColor = true;
            btnExploreFolder.Click += btnExploreFolder_Click;
            // 
            // btnExport
            // 
            btnExport.AutoSize = true;
            btnExport.Dock = DockStyle.Top;
            btnExport.Location = new Point(0, 44);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(374, 27);
            btnExport.TabIndex = 2;
            btnExport.Text = "导出数据文件";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.AutoSize = true;
            btnImport.Dock = DockStyle.Top;
            btnImport.Location = new Point(0, 71);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(374, 27);
            btnImport.TabIndex = 3;
            btnImport.Text = "导入数据文件";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnClearCurrentUser
            // 
            btnClearCurrentUser.AutoSize = true;
            btnClearCurrentUser.Dock = DockStyle.Top;
            btnClearCurrentUser.Location = new Point(0, 98);
            btnClearCurrentUser.Name = "btnClearCurrentUser";
            btnClearCurrentUser.Size = new Size(374, 27);
            btnClearCurrentUser.TabIndex = 4;
            btnClearCurrentUser.Text = "清空当前用户数据文件";
            btnClearCurrentUser.UseVisualStyleBackColor = true;
            btnClearCurrentUser.Click += btnClearCurrentUser_Click;
            // 
            // DataFileSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClearCurrentUser);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnExploreFolder);
            Controls.Add(flowLayoutPanel1);
            Name = "DataFileSettingsPage";
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
        private Button btnClearCurrentUser;
    }
}
