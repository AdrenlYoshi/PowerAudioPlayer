namespace PowerAudioPlayer.UI
{
    partial class LyricsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LyricsForm));
            lyricsView1 = new CustomControls.LyricsView();
            SuspendLayout();
            // 
            // lyricsView1
            // 
            lyricsView1.Dock = DockStyle.Fill;
            lyricsView1.Location = new Point(0, 0);
            lyricsView1.Name = "lyricsView1";
            lyricsView1.Size = new Size(727, 519);
            lyricsView1.TabIndex = 0;
            // 
            // LyricsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 519);
            Controls.Add(lyricsView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LyricsForm";
            ShowInTaskbar = false;
            Text = "歌词";
            FormClosing += LyricsForm_FormClosing;
            ForeColorChanged += LyricsForm_ForeColorChanged;
            LocationChanged += LyricsForm_LocationChanged;
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.LyricsView lyricsView1;
    }
}