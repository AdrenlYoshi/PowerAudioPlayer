namespace PowerAudioPlayer.UI
{
    partial class PlaylistEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistEditorForm));
            playlistEditor = new CustomControls.PlaylistEditor();
            SuspendLayout();
            // 
            // playlistEditor
            // 
            playlistEditor.AllowDrop = true;
            playlistEditor.Dock = DockStyle.Fill;
            playlistEditor.EditPlaylistIndex = 0;
            playlistEditor.IsEditActivePlaylist = true;
            playlistEditor.Location = new Point(0, 0);
            playlistEditor.Margin = new Padding(4, 3, 4, 3);
            playlistEditor.Name = "playlistEditor";
            playlistEditor.Size = new Size(508, 465);
            playlistEditor.TabIndex = 0;
            playlistEditor.PlayItem += playlistEditor_PlayItem;
            // 
            // PlaylistEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 465);
            Controls.Add(playlistEditor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlaylistEditorForm";
            ShowInTaskbar = false;
            Text = "播放列表编辑器";
            FormClosing += PlaylistEditorForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.PlaylistEditor playlistEditor;
    }
}