
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
            lbldotNETVersion = new Label();
            lblLastCompileTime = new Label();
            lblProductName = new Label();
            lblArchitecture = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Resources.PowerAudioPlayerBig;
            logoPictureBox.Location = new Point(12, 12);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(77, 45);
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
            rtbAcknowledgement.Location = new Point(12, 148);
            rtbAcknowledgement.Name = "rtbAcknowledgement";
            rtbAcknowledgement.ReadOnly = true;
            rtbAcknowledgement.Size = new Size(375, 183);
            rtbAcknowledgement.TabIndex = 32;
            rtbAcknowledgement.Text = "";
            rtbAcknowledgement.LinkClicked += rtbAcknowledgement_LinkClicked;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(12, 60);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(66, 17);
            lblVersion.TabIndex = 34;
            lblVersion.Text = "lblVersion";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(12, 77);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(77, 17);
            lblCompany.TabIndex = 35;
            lblCompany.Text = "lblCompany";
            // 
            // lbldotNETVersion
            // 
            lbldotNETVersion.AutoSize = true;
            lbldotNETVersion.Location = new Point(12, 94);
            lbldotNETVersion.Name = "lbldotNETVersion";
            lbldotNETVersion.Size = new Size(110, 17);
            lbldotNETVersion.TabIndex = 37;
            lbldotNETVersion.Text = "lbldotNETVersion";
            // 
            // lblLastCompileTime
            // 
            lblLastCompileTime.AutoSize = true;
            lblLastCompileTime.Location = new Point(12, 128);
            lblLastCompileTime.Name = "lblLastCompileTime";
            lblLastCompileTime.Size = new Size(121, 17);
            lblLastCompileTime.TabIndex = 38;
            lblLastCompileTime.Text = "lblLastCompileTime";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblProductName.Location = new Point(95, 12);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(299, 41);
            lblProductName.TabIndex = 39;
            lblProductName.Tag = "http://github.com/AdrenlYoshi/PowerAudioPlayer";
            lblProductName.Text = "PowerAudioPlayer";
            lblProductName.Click += lblProductName_Click;
            // 
            // lblArchitecture
            // 
            lblArchitecture.AutoSize = true;
            lblArchitecture.Location = new Point(12, 111);
            lblArchitecture.Name = "lblArchitecture";
            lblArchitecture.Size = new Size(91, 17);
            lblArchitecture.TabIndex = 40;
            lblArchitecture.Text = "lblArchitecture";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(399, 378);
            Controls.Add(lblArchitecture);
            Controls.Add(lblProductName);
            Controls.Add(rtbAcknowledgement);
            Controls.Add(lblLastCompileTime);
            Controls.Add(lbldotNETVersion);
            Controls.Add(lblCompany);
            Controls.Add(lblVersion);
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
        private Label lbldotNETVersion;
        private Label lblLastCompileTime;
        private Label lblProductName;
        private Label lblArchitecture;
    }
}
