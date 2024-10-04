
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
            llblProgramName = new LinkLabel();
            lbldotNETVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Top;
            logoPictureBox.Image = Resources.PowerAudioPlayerBig;
            logoPictureBox.Location = new Point(0, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(398, 48);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 26;
            logoPictureBox.TabStop = false;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(297, 311);
            okButton.Margin = new Padding(4);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 27);
            okButton.TabIndex = 31;
            okButton.Text = "确定(&O)";
            // 
            // rtbAcknowledgement
            // 
            rtbAcknowledgement.Dock = DockStyle.Top;
            rtbAcknowledgement.Location = new Point(0, 116);
            rtbAcknowledgement.Name = "rtbAcknowledgement";
            rtbAcknowledgement.ReadOnly = true;
            rtbAcknowledgement.Size = new Size(398, 188);
            rtbAcknowledgement.TabIndex = 32;
            rtbAcknowledgement.Text = "";
            rtbAcknowledgement.LinkClicked += rtbAcknowledgement_LinkClicked;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Dock = DockStyle.Top;
            lblVersion.Location = new Point(0, 65);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(66, 17);
            lblVersion.TabIndex = 34;
            lblVersion.Text = "lblVersion";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Dock = DockStyle.Top;
            lblCompany.Location = new Point(0, 82);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(77, 17);
            lblCompany.TabIndex = 35;
            lblCompany.Text = "lblCompany";
            // 
            // llblProgramName
            // 
            llblProgramName.AutoSize = true;
            llblProgramName.Dock = DockStyle.Top;
            llblProgramName.Location = new Point(0, 48);
            llblProgramName.Name = "llblProgramName";
            llblProgramName.Size = new Size(111, 17);
            llblProgramName.TabIndex = 36;
            llblProgramName.TabStop = true;
            llblProgramName.Text = "llblProgramName";
            llblProgramName.LinkClicked += llblProgramName_LinkClicked;
            // 
            // lbldotNETVersion
            // 
            lbldotNETVersion.AutoSize = true;
            lbldotNETVersion.Dock = DockStyle.Top;
            lbldotNETVersion.Location = new Point(0, 99);
            lbldotNETVersion.Name = "lbldotNETVersion";
            lbldotNETVersion.Size = new Size(110, 17);
            lbldotNETVersion.TabIndex = 37;
            lbldotNETVersion.Text = "lbldotNETVersion";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 349);
            Controls.Add(rtbAcknowledgement);
            Controls.Add(lbldotNETVersion);
            Controls.Add(lblCompany);
            Controls.Add(lblVersion);
            Controls.Add(llblProgramName);
            Controls.Add(logoPictureBox);
            Controls.Add(okButton);
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
        private LinkLabel llblProgramName;
        private Label lbldotNETVersion;
    }
}
