
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
            labelProductName = new Label();
            labelVersion = new Label();
            labelCompanyName = new Label();
            okButton = new Button();
            rtbAcknowledgement = new RichTextBox();
            labelDotNetVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Resources.PowerAudioPlayerBig;
            logoPictureBox.Location = new Point(4, 4);
            logoPictureBox.Margin = new Padding(4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(48, 48);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 26;
            logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.Location = new Point(63, 4);
            labelProductName.Margin = new Padding(7, 0, 4, 0);
            labelProductName.MaximumSize = new Size(0, 22);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(321, 22);
            labelProductName.TabIndex = 27;
            labelProductName.Text = "产品名称";
            labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Location = new Point(63, 26);
            labelVersion.Margin = new Padding(7, 0, 4, 0);
            labelVersion.MaximumSize = new Size(0, 22);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(321, 22);
            labelVersion.TabIndex = 25;
            labelVersion.Text = "版本";
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Location = new Point(63, 48);
            labelCompanyName.Margin = new Padding(7, 0, 4, 0);
            labelCompanyName.MaximumSize = new Size(0, 22);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(321, 22);
            labelCompanyName.TabIndex = 29;
            labelCompanyName.Text = "公司名称";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(297, 290);
            okButton.Margin = new Padding(4);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 27);
            okButton.TabIndex = 31;
            okButton.Text = "确定(&O)";
            // 
            // rtbAcknowledgement
            // 
            rtbAcknowledgement.Location = new Point(13, 95);
            rtbAcknowledgement.Name = "rtbAcknowledgement";
            rtbAcknowledgement.ReadOnly = true;
            rtbAcknowledgement.Size = new Size(372, 188);
            rtbAcknowledgement.TabIndex = 32;
            rtbAcknowledgement.Text = "";
            rtbAcknowledgement.LinkClicked += rtbAcknowledgement_LinkClicked;
            // 
            // labelDotNetVersion
            // 
            labelDotNetVersion.Location = new Point(63, 70);
            labelDotNetVersion.Margin = new Padding(7, 0, 4, 0);
            labelDotNetVersion.MaximumSize = new Size(0, 22);
            labelDotNetVersion.Name = "labelDotNetVersion";
            labelDotNetVersion.Size = new Size(321, 22);
            labelDotNetVersion.TabIndex = 33;
            labelDotNetVersion.Text = "公司名称";
            labelDotNetVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 333);
            Controls.Add(labelDotNetVersion);
            Controls.Add(rtbAcknowledgement);
            Controls.Add(logoPictureBox);
            Controls.Add(labelProductName);
            Controls.Add(labelVersion);
            Controls.Add(labelCompanyName);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Padding = new Padding(10, 12, 10, 12);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutBox1";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCompanyName;
        private Button okButton;
        private RichTextBox rtbAcknowledgement;
        private Label labelDotNetVersion;
    }
}
