namespace PowerAudioPlayer.UI
{
    partial class SupportrdFormatForm
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
            lvFormat = new BrightIdeasSoftware.FastObjectListView();
            ((System.ComponentModel.ISupportInitialize)lvFormat).BeginInit();
            SuspendLayout();
            // 
            // lvFormat
            // 
            lvFormat.Dock = DockStyle.Fill;
            lvFormat.FullRowSelect = true;
            lvFormat.GridLines = true;
            lvFormat.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvFormat.Location = new Point(10, 10);
            lvFormat.MultiSelect = false;
            lvFormat.Name = "lvFormat";
            lvFormat.ShowGroups = false;
            lvFormat.Size = new Size(507, 480);
            lvFormat.TabIndex = 0;
            lvFormat.View = View.Details;
            lvFormat.VirtualMode = true;
            // 
            // SupportrdFormatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 500);
            Controls.Add(lvFormat);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupportrdFormatForm";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "支持的格式列表";
            ((System.ComponentModel.ISupportInitialize)lvFormat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lvFormat;
    }
}