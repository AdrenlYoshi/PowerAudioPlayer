
namespace PowerAudioPlayer.UI
{
    partial class AboutForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            logoPictureBox = new PictureBox();
            okButton = new Button();
            rtbAcknowledgement = new RichTextBox();
            lblVersion = new Label();
            lblCompany = new Label();
            llblProductName = new LinkLabel();
            lbldotNETVersion = new Label();
            lblLastCompileTime = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Top;
            logoPictureBox.Image = Resources.PowerAudioPlayerBig;
            logoPictureBox.Location = new Point(0, 17);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(398, 45);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 26;
            logoPictureBox.TabStop = false;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(297, 338);
            okButton.Margin = new Padding(4);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 27);
            okButton.TabIndex = 31;
            okButton.Text = "确定(&O)";
            // 
            // rtbAcknowledgement
            // 
            rtbAcknowledgement.Dock = DockStyle.Top;
            rtbAcknowledgement.Location = new Point(0, 130);
            rtbAcknowledgement.Name = "rtbAcknowledgement";
            rtbAcknowledgement.ReadOnly = true;
            rtbAcknowledgement.Size = new Size(398, 201);
            rtbAcknowledgement.TabIndex = 32;
            rtbAcknowledgement.Text = "";
            rtbAcknowledgement.LinkClicked += rtbAcknowledgement_LinkClicked;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Dock = DockStyle.Top;
            lblVersion.Location = new Point(0, 62);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(66, 17);
            lblVersion.TabIndex = 34;
            lblVersion.Text = "lblVersion";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Dock = DockStyle.Top;
            lblCompany.Location = new Point(0, 79);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(77, 17);
            lblCompany.TabIndex = 35;
            lblCompany.Text = "lblCompany";
            // 
            // llblProductName
            // 
            llblProductName.Dock = DockStyle.Top;
            llblProductName.Location = new Point(0, 0);
            llblProductName.Name = "llblProductName";
            llblProductName.Size = new Size(398, 17);
            llblProductName.TabIndex = 36;
            llblProductName.TabStop = true;
            llblProductName.Text = "llblProductName";
            llblProductName.TextAlign = ContentAlignment.MiddleCenter;
            llblProductName.LinkClicked += llblProgramName_LinkClicked;
            // 
            // lbldotNETVersion
            // 
            lbldotNETVersion.AutoSize = true;
            lbldotNETVersion.Dock = DockStyle.Top;
            lbldotNETVersion.Location = new Point(0, 96);
            lbldotNETVersion.Name = "lbldotNETVersion";
            lbldotNETVersion.Size = new Size(110, 17);
            lbldotNETVersion.TabIndex = 37;
            lbldotNETVersion.Text = "lbldotNETVersion";
            // 
            // lblLastCompileTime
            // 
            lblLastCompileTime.AutoSize = true;
            lblLastCompileTime.Dock = DockStyle.Top;
            lblLastCompileTime.Location = new Point(0, 113);
            lblLastCompileTime.Name = "lblLastCompileTime";
            lblLastCompileTime.Size = new Size(121, 17);
            lblLastCompileTime.TabIndex = 38;
            lblLastCompileTime.Text = "lblLastCompileTime";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 378);
            Controls.Add(rtbAcknowledgement);
            Controls.Add(lblLastCompileTime);
            Controls.Add(lbldotNETVersion);
            Controls.Add(lblCompany);
            Controls.Add(lblVersion);
            Controls.Add(logoPictureBox);
            Controls.Add(okButton);
            Controls.Add(llblProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoPictureBox;
        private Button okButton;
        private RichTextBox rtbAcknowledgement;
        private Label lblVersion;
        private Label lblCompany;
        private LinkLabel llblProductName;
        private Label lbldotNETVersion;
        private Label lblLastCompileTime;
    }
}
