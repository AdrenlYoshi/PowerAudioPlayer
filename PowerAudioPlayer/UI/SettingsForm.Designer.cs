namespace PowerAudioPlayer.UI
{
    partial class SettingsForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            playSettingsPage1 = new CustomControls.SettingsPages.PlaySettingsPage();
            tabPage2 = new TabPage();
            appearanceSettingsPage1 = new CustomControls.SettingsPages.AppearanceSettingsPage();
            tabPage3 = new TabPage();
            mediaLibrarySettingsPage1 = new CustomControls.SettingsPages.MediaLibrarySettingsPage();
            tabPage4 = new TabPage();
            controlSettingsPage2 = new CustomControls.SettingsPages.ControlSettingsPage();
            tabPage5 = new TabPage();
            dataSettingsPage1 = new CustomControls.SettingsPages.DataFileSettingsPage();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(529, 438);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(playSettingsPage1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(521, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "播放";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // playSettingsPage1
            // 
            playSettingsPage1.AutoScroll = true;
            playSettingsPage1.Dock = DockStyle.Fill;
            playSettingsPage1.Location = new Point(3, 3);
            playSettingsPage1.Name = "playSettingsPage1";
            playSettingsPage1.Owner = null;
            playSettingsPage1.Size = new Size(515, 402);
            playSettingsPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(appearanceSettingsPage1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 70);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "外观";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // appearanceSettingsPage1
            // 
            appearanceSettingsPage1.AutoScroll = true;
            appearanceSettingsPage1.Dock = DockStyle.Fill;
            appearanceSettingsPage1.Location = new Point(3, 3);
            appearanceSettingsPage1.Name = "appearanceSettingsPage1";
            appearanceSettingsPage1.Owner = null;
            appearanceSettingsPage1.Size = new Size(186, 64);
            appearanceSettingsPage1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(mediaLibrarySettingsPage1);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(192, 70);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "媒体库";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // mediaLibrarySettingsPage1
            // 
            mediaLibrarySettingsPage1.AutoScroll = true;
            mediaLibrarySettingsPage1.Dock = DockStyle.Fill;
            mediaLibrarySettingsPage1.Location = new Point(0, 0);
            mediaLibrarySettingsPage1.Name = "mediaLibrarySettingsPage1";
            mediaLibrarySettingsPage1.Owner = null;
            mediaLibrarySettingsPage1.Size = new Size(192, 70);
            mediaLibrarySettingsPage1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(controlSettingsPage2);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(192, 70);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "操作";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // controlSettingsPage2
            // 
            controlSettingsPage2.AutoScroll = true;
            controlSettingsPage2.Dock = DockStyle.Fill;
            controlSettingsPage2.Location = new Point(0, 0);
            controlSettingsPage2.Name = "controlSettingsPage2";
            controlSettingsPage2.Size = new Size(192, 70);
            controlSettingsPage2.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataSettingsPage1);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(192, 70);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "数据文件";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataSettingsPage1
            // 
            dataSettingsPage1.Dock = DockStyle.Fill;
            dataSettingsPage1.Location = new Point(3, 3);
            dataSettingsPage1.Name = "dataSettingsPage1";
            dataSettingsPage1.Size = new Size(186, 64);
            dataSettingsPage1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 438);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 1;
            label1.Text = "*重启程序后生效";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(529, 455);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            Load += SettingsForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private CustomControls.SettingsPages.PlaySettingsPage playSettingsPage1;
        private CustomControls.SettingsPages.AppearanceSettingsPage appearanceSettingsPage1;
        private CustomControls.SettingsPages.ControlSettingsPage controlSettingsPage2;
        private CustomControls.SettingsPages.MediaLibrarySettingsPage mediaLibrarySettingsPage1;
        private TabPage tabPage5;
        private CustomControls.SettingsPages.DataFileSettingsPage dataSettingsPage1;
    }
}