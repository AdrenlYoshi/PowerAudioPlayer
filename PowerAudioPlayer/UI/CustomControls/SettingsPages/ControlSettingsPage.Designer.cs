namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    partial class ControlSettingsPage
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
            groupBox5 = new GroupBox();
            cbEnableTrackbarProgress = new CheckBox();
            cbShowStatusInTaskbarIcon = new CheckBox();
            cbEnableTrackbarControlButton = new CheckBox();
            groupBox1 = new GroupBox();
            cbResponseAppCommand = new CheckBox();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(cbEnableTrackbarProgress);
            groupBox5.Controls.Add(cbShowStatusInTaskbarIcon);
            groupBox5.Controls.Add(cbEnableTrackbarControlButton);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(602, 85);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "控制";
            // 
            // cbEnableTrackbarProgress
            // 
            cbEnableTrackbarProgress.AutoSize = true;
            cbEnableTrackbarProgress.Dock = DockStyle.Top;
            cbEnableTrackbarProgress.Location = new Point(3, 61);
            cbEnableTrackbarProgress.Name = "cbEnableTrackbarProgress";
            cbEnableTrackbarProgress.Size = new Size(596, 21);
            cbEnableTrackbarProgress.TabIndex = 14;
            cbEnableTrackbarProgress.Text = "在任务栏图标中显示进度";
            cbEnableTrackbarProgress.UseVisualStyleBackColor = true;
            // 
            // cbShowStatusInTaskbarIcon
            // 
            cbShowStatusInTaskbarIcon.AutoSize = true;
            cbShowStatusInTaskbarIcon.Dock = DockStyle.Top;
            cbShowStatusInTaskbarIcon.Location = new Point(3, 40);
            cbShowStatusInTaskbarIcon.Name = "cbShowStatusInTaskbarIcon";
            cbShowStatusInTaskbarIcon.Size = new Size(596, 21);
            cbShowStatusInTaskbarIcon.TabIndex = 13;
            cbShowStatusInTaskbarIcon.Text = "在任务栏图标中显示状态";
            cbShowStatusInTaskbarIcon.UseVisualStyleBackColor = true;
            // 
            // cbEnableTrackbarControlButton
            // 
            cbEnableTrackbarControlButton.AutoSize = true;
            cbEnableTrackbarControlButton.Dock = DockStyle.Top;
            cbEnableTrackbarControlButton.Location = new Point(3, 19);
            cbEnableTrackbarControlButton.Name = "cbEnableTrackbarControlButton";
            cbEnableTrackbarControlButton.Size = new Size(596, 21);
            cbEnableTrackbarControlButton.TabIndex = 12;
            cbEnableTrackbarControlButton.Text = "*启用任务栏控制按钮";
            cbEnableTrackbarControlButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(cbResponseAppCommand);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 43);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "按键";
            // 
            // cbResponseAppCommand
            // 
            cbResponseAppCommand.AutoSize = true;
            cbResponseAppCommand.Dock = DockStyle.Top;
            cbResponseAppCommand.Location = new Point(3, 19);
            cbResponseAppCommand.Name = "cbResponseAppCommand";
            cbResponseAppCommand.Size = new Size(596, 21);
            cbResponseAppCommand.TabIndex = 0;
            cbResponseAppCommand.Text = "响应多媒体按键(WM_APPCOMMAND)";
            cbResponseAppCommand.UseVisualStyleBackColor = true;
            // 
            // ControlSettingsPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            Controls.Add(groupBox1);
            Controls.Add(groupBox5);
            Name = "ControlSettingsPage";
            Size = new Size(602, 461);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private CheckBox cbEnableTrackbarProgress;
        private CheckBox cbShowStatusInTaskbarIcon;
        private CheckBox cbEnableTrackbarControlButton;
        private GroupBox groupBox1;
        private CheckBox cbResponseAppCommand;
    }
}
