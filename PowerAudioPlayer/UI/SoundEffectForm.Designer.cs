namespace PowerAudioPlayer.UI
{
    partial class SoundEffectForm
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
            components = new System.ComponentModel.Container();
            cbEnableEQ = new CheckBox();
            label11 = new Label();
            trbGain = new TrackBar();
            btnResetEQ = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trbEQ10 = new TrackBar();
            trbEQ9 = new TrackBar();
            trbEQ8 = new TrackBar();
            trbEQ7 = new TrackBar();
            trbEQ6 = new TrackBar();
            trbEQ5 = new TrackBar();
            trbEQ4 = new TrackBar();
            trbEQ3 = new TrackBar();
            trbEQ2 = new TrackBar();
            trbEQ1 = new TrackBar();
            toolTip = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)trbGain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbEnableEQ
            // 
            cbEnableEQ.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cbEnableEQ, 3);
            cbEnableEQ.Dock = DockStyle.Fill;
            cbEnableEQ.Location = new Point(3, 277);
            cbEnableEQ.Name = "cbEnableEQ";
            cbEnableEQ.Size = new Size(147, 29);
            cbEnableEQ.TabIndex = 23;
            cbEnableEQ.Text = "启用";
            cbEnableEQ.UseVisualStyleBackColor = true;
            cbEnableEQ.CheckedChanged += cbEnableEQ_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(513, 257);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 22;
            label11.Text = "放大";
            // 
            // trbGain
            // 
            trbGain.Dock = DockStyle.Fill;
            trbGain.Location = new Point(513, 3);
            trbGain.Maximum = 400;
            trbGain.Minimum = -400;
            trbGain.Name = "trbGain";
            trbGain.Orientation = Orientation.Vertical;
            trbGain.Size = new Size(49, 251);
            trbGain.TabIndex = 21;
            trbGain.Tag = "9";
            trbGain.TickFrequency = 5;
            trbGain.TickStyle = TickStyle.Both;
            trbGain.Scroll += trbGain_Scroll;
            trbGain.ValueChanged += trb_ValueChanged;
            // 
            // btnResetEQ
            // 
            tableLayoutPanel1.SetColumnSpan(btnResetEQ, 3);
            btnResetEQ.Dock = DockStyle.Fill;
            btnResetEQ.Location = new Point(156, 277);
            btnResetEQ.Name = "btnResetEQ";
            btnResetEQ.Size = new Size(147, 29);
            btnResetEQ.TabIndex = 20;
            btnResetEQ.Text = "重置";
            btnResetEQ.UseVisualStyleBackColor = true;
            btnResetEQ.Click += btnResetEQ_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 257);
            label10.Name = "label10";
            label10.Size = new Size(30, 17);
            label10.TabIndex = 19;
            label10.Text = "16K";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 257);
            label9.Name = "label9";
            label9.Size = new Size(23, 17);
            label9.TabIndex = 18;
            label9.Text = "8K";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 257);
            label8.Name = "label8";
            label8.Size = new Size(23, 17);
            label8.TabIndex = 17;
            label8.Text = "4K";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 257);
            label7.Name = "label7";
            label7.Size = new Size(23, 17);
            label7.TabIndex = 16;
            label7.Text = "2K";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 257);
            label6.Name = "label6";
            label6.Size = new Size(33, 17);
            label6.TabIndex = 15;
            label6.Text = "1.5K";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 257);
            label5.Name = "label5";
            label5.Size = new Size(23, 17);
            label5.TabIndex = 14;
            label5.Text = "1K";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 257);
            label4.Name = "label4";
            label4.Size = new Size(29, 17);
            label4.TabIndex = 13;
            label4.Text = "550";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 257);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 12;
            label3.Text = "250";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 257);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 11;
            label2.Text = "125";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 257);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 10;
            label1.Text = "80";
            // 
            // trbEQ10
            // 
            trbEQ10.Dock = DockStyle.Fill;
            trbEQ10.Location = new Point(462, 3);
            trbEQ10.Maximum = 130;
            trbEQ10.Minimum = -130;
            trbEQ10.Name = "trbEQ10";
            trbEQ10.Orientation = Orientation.Vertical;
            trbEQ10.Size = new Size(45, 251);
            trbEQ10.TabIndex = 9;
            trbEQ10.Tag = "9";
            trbEQ10.TickFrequency = 3;
            trbEQ10.TickStyle = TickStyle.Both;
            trbEQ10.Scroll += EqTrackBar_Scroll;
            trbEQ10.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ9
            // 
            trbEQ9.Dock = DockStyle.Fill;
            trbEQ9.Location = new Point(411, 3);
            trbEQ9.Maximum = 130;
            trbEQ9.Minimum = -130;
            trbEQ9.Name = "trbEQ9";
            trbEQ9.Orientation = Orientation.Vertical;
            trbEQ9.Size = new Size(45, 251);
            trbEQ9.TabIndex = 8;
            trbEQ9.Tag = "8";
            trbEQ9.TickFrequency = 3;
            trbEQ9.TickStyle = TickStyle.Both;
            trbEQ9.Scroll += EqTrackBar_Scroll;
            trbEQ9.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ8
            // 
            trbEQ8.Dock = DockStyle.Fill;
            trbEQ8.Location = new Point(360, 3);
            trbEQ8.Maximum = 130;
            trbEQ8.Minimum = -130;
            trbEQ8.Name = "trbEQ8";
            trbEQ8.Orientation = Orientation.Vertical;
            trbEQ8.Size = new Size(45, 251);
            trbEQ8.TabIndex = 7;
            trbEQ8.Tag = "7";
            trbEQ8.TickFrequency = 3;
            trbEQ8.TickStyle = TickStyle.Both;
            trbEQ8.Scroll += EqTrackBar_Scroll;
            trbEQ8.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ7
            // 
            trbEQ7.Dock = DockStyle.Fill;
            trbEQ7.Location = new Point(309, 3);
            trbEQ7.Maximum = 130;
            trbEQ7.Minimum = -130;
            trbEQ7.Name = "trbEQ7";
            trbEQ7.Orientation = Orientation.Vertical;
            trbEQ7.Size = new Size(45, 251);
            trbEQ7.TabIndex = 6;
            trbEQ7.Tag = "6";
            trbEQ7.TickFrequency = 3;
            trbEQ7.TickStyle = TickStyle.Both;
            trbEQ7.Scroll += EqTrackBar_Scroll;
            trbEQ7.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ6
            // 
            trbEQ6.Dock = DockStyle.Fill;
            trbEQ6.Location = new Point(258, 3);
            trbEQ6.Maximum = 130;
            trbEQ6.Minimum = -130;
            trbEQ6.Name = "trbEQ6";
            trbEQ6.Orientation = Orientation.Vertical;
            trbEQ6.Size = new Size(45, 251);
            trbEQ6.TabIndex = 5;
            trbEQ6.Tag = "5";
            trbEQ6.TickFrequency = 3;
            trbEQ6.TickStyle = TickStyle.Both;
            trbEQ6.Scroll += EqTrackBar_Scroll;
            trbEQ6.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ5
            // 
            trbEQ5.Dock = DockStyle.Fill;
            trbEQ5.Location = new Point(207, 3);
            trbEQ5.Maximum = 130;
            trbEQ5.Minimum = -130;
            trbEQ5.Name = "trbEQ5";
            trbEQ5.Orientation = Orientation.Vertical;
            trbEQ5.Size = new Size(45, 251);
            trbEQ5.TabIndex = 4;
            trbEQ5.Tag = "4";
            trbEQ5.TickFrequency = 3;
            trbEQ5.TickStyle = TickStyle.Both;
            trbEQ5.Scroll += EqTrackBar_Scroll;
            trbEQ5.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ4
            // 
            trbEQ4.Dock = DockStyle.Fill;
            trbEQ4.Location = new Point(156, 3);
            trbEQ4.Maximum = 130;
            trbEQ4.Minimum = -130;
            trbEQ4.Name = "trbEQ4";
            trbEQ4.Orientation = Orientation.Vertical;
            trbEQ4.Size = new Size(45, 251);
            trbEQ4.TabIndex = 3;
            trbEQ4.Tag = "3";
            trbEQ4.TickFrequency = 3;
            trbEQ4.TickStyle = TickStyle.Both;
            trbEQ4.Scroll += EqTrackBar_Scroll;
            trbEQ4.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ3
            // 
            trbEQ3.Dock = DockStyle.Fill;
            trbEQ3.Location = new Point(105, 3);
            trbEQ3.Maximum = 130;
            trbEQ3.Minimum = -130;
            trbEQ3.Name = "trbEQ3";
            trbEQ3.Orientation = Orientation.Vertical;
            trbEQ3.Size = new Size(45, 251);
            trbEQ3.TabIndex = 2;
            trbEQ3.Tag = "2";
            trbEQ3.TickFrequency = 3;
            trbEQ3.TickStyle = TickStyle.Both;
            trbEQ3.Scroll += EqTrackBar_Scroll;
            trbEQ3.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ2
            // 
            trbEQ2.Dock = DockStyle.Fill;
            trbEQ2.Location = new Point(54, 3);
            trbEQ2.Maximum = 130;
            trbEQ2.Minimum = -130;
            trbEQ2.Name = "trbEQ2";
            trbEQ2.Orientation = Orientation.Vertical;
            trbEQ2.Size = new Size(45, 251);
            trbEQ2.TabIndex = 1;
            trbEQ2.Tag = "1";
            trbEQ2.TickFrequency = 3;
            trbEQ2.TickStyle = TickStyle.Both;
            trbEQ2.Scroll += EqTrackBar_Scroll;
            trbEQ2.ValueChanged += trb_ValueChanged;
            // 
            // trbEQ1
            // 
            trbEQ1.Dock = DockStyle.Fill;
            trbEQ1.Location = new Point(3, 3);
            trbEQ1.Maximum = 130;
            trbEQ1.Minimum = -130;
            trbEQ1.Name = "trbEQ1";
            trbEQ1.Orientation = Orientation.Vertical;
            trbEQ1.Size = new Size(45, 251);
            trbEQ1.TabIndex = 0;
            trbEQ1.Tag = "0";
            trbEQ1.TickFrequency = 3;
            trbEQ1.TickStyle = TickStyle.Both;
            trbEQ1.Scroll += EqTrackBar_Scroll;
            trbEQ1.ValueChanged += trb_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(trbEQ1, 0, 0);
            tableLayoutPanel1.Controls.Add(cbEnableEQ, 0, 2);
            tableLayoutPanel1.Controls.Add(trbEQ2, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 10, 1);
            tableLayoutPanel1.Controls.Add(trbEQ3, 2, 0);
            tableLayoutPanel1.Controls.Add(trbGain, 10, 0);
            tableLayoutPanel1.Controls.Add(label10, 9, 1);
            tableLayoutPanel1.Controls.Add(trbEQ4, 3, 0);
            tableLayoutPanel1.Controls.Add(label9, 8, 1);
            tableLayoutPanel1.Controls.Add(trbEQ5, 4, 0);
            tableLayoutPanel1.Controls.Add(label8, 7, 1);
            tableLayoutPanel1.Controls.Add(trbEQ6, 5, 0);
            tableLayoutPanel1.Controls.Add(label7, 6, 1);
            tableLayoutPanel1.Controls.Add(trbEQ7, 6, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 1);
            tableLayoutPanel1.Controls.Add(trbEQ8, 7, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 1);
            tableLayoutPanel1.Controls.Add(trbEQ9, 8, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(trbEQ10, 9, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(btnResetEQ, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(565, 309);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // SoundEffectForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(565, 309);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SoundEffectForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "声音效果";
            ((System.ComponentModel.ISupportInitialize)trbGain).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ10).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ9).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ8).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ7).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEQ1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TrackBar trbEQ1;
        private TrackBar trbEQ10;
        private TrackBar trbEQ9;
        private TrackBar trbEQ8;
        private TrackBar trbEQ7;
        private TrackBar trbEQ6;
        private TrackBar trbEQ5;
        private TrackBar trbEQ4;
        private TrackBar trbEQ3;
        private TrackBar trbEQ2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnResetEQ;
        private Label label11;
        private TrackBar trbGain;
        private CheckBox cbEnableEQ;
        private ToolTip toolTip;
        private TableLayoutPanel tableLayoutPanel1;
    }
}