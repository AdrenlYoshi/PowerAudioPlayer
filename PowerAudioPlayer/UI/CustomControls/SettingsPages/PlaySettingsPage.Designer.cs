namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    partial class PlaySettingsPage
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            nudSampleRate = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            cmbDevice = new ComboBox();
            groupBox2 = new GroupBox();
            tbMIDISoundFont = new WinFormsExtendedControls.FilePanel.OpenFilePanel();
            numMIDIVoices = new WinFormsExtendedControls.LabeledNumericUpDown();
            groupBox3 = new GroupBox();
            cbStopPlayingWhenError = new CheckBox();
            groupBox4 = new GroupBox();
            numTimeOut = new WinFormsExtendedControls.LabeledNumericUpDown();
            numNetBuffer = new WinFormsExtendedControls.LabeledNumericUpDown();
            numPlayBuffer = new WinFormsExtendedControls.LabeledNumericUpDown();
            groupBox5 = new GroupBox();
            rbCoreBASS = new RadioButton();
            rbCoreMCI = new RadioButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSampleRate).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "设备";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(nudSampleRate, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbDevice, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(331, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // nudSampleRate
            // 
            nudSampleRate.Dock = DockStyle.Top;
            nudSampleRate.Location = new Point(109, 34);
            nudSampleRate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSampleRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSampleRate.Name = "nudSampleRate";
            nudSampleRate.Size = new Size(219, 23);
            nudSampleRate.TabIndex = 5;
            nudSampleRate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 0;
            label1.Text = "*输出设备";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 1;
            label2.Text = "*输出频率（Hz）";
            // 
            // cmbDevice
            // 
            cmbDevice.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDevice.DisplayMember = "p";
            cmbDevice.Dock = DockStyle.Top;
            cmbDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDevice.FormattingEnabled = true;
            cmbDevice.Items.AddRange(new object[] { "-1.默认设备", "0.无声音设备" });
            cmbDevice.Location = new Point(109, 3);
            cmbDevice.Name = "cmbDevice";
            cmbDevice.Size = new Size(219, 25);
            cmbDevice.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(tbMIDISoundFont);
            groupBox2.Controls.Add(numMIDIVoices);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MIDI";
            // 
            // tbMIDISoundFont
            // 
            tbMIDISoundFont.Dock = DockStyle.Top;
            tbMIDISoundFont.FileFilter = "";
            tbMIDISoundFont.LabelWidth = 46;
            tbMIDISoundFont.Location = new Point(3, 49);
            tbMIDISoundFont.Margin = new Padding(4, 4, 4, 4);
            tbMIDISoundFont.Name = "tbMIDISoundFont";
            tbMIDISoundFont.SelectedFile = "";
            tbMIDISoundFont.Size = new Size(331, 26);
            tbMIDISoundFont.TabIndex = 0;
            tbMIDISoundFont.Text = "音色库";
            // 
            // numMIDIVoices
            // 
            numMIDIVoices.DecimalPlaces = 0;
            numMIDIVoices.Dock = DockStyle.Top;
            numMIDIVoices.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numMIDIVoices.LabelAutoSize = true;
            numMIDIVoices.LabelText = "最大样本数";
            numMIDIVoices.LabelWidth = 70;
            numMIDIVoices.Location = new Point(3, 19);
            numMIDIVoices.Margin = new Padding(4, 4, 4, 4);
            numMIDIVoices.Maxinum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMIDIVoices.MinimumSize = new Size(0, 30);
            numMIDIVoices.Mininum = new decimal(new int[] { 1, 0, 0, 0 });
            numMIDIVoices.Name = "numMIDIVoices";
            numMIDIVoices.ReadOnly = false;
            numMIDIVoices.Size = new Size(331, 30);
            numMIDIVoices.TabIndex = 1;
            numMIDIVoices.Text = "100";
            numMIDIVoices.TextBoxBackColor = SystemColors.Window;
            numMIDIVoices.TextBoxForeColor = SystemColors.WindowText;
            numMIDIVoices.ThousandsSeparator = false;
            numMIDIVoices.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(cbStopPlayingWhenError);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 160);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 43);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "行为";
            // 
            // cbStopPlayingWhenError
            // 
            cbStopPlayingWhenError.AutoSize = true;
            cbStopPlayingWhenError.Dock = DockStyle.Top;
            cbStopPlayingWhenError.Location = new Point(3, 19);
            cbStopPlayingWhenError.Name = "cbStopPlayingWhenError";
            cbStopPlayingWhenError.Size = new Size(331, 21);
            cbStopPlayingWhenError.TabIndex = 0;
            cbStopPlayingWhenError.Text = "播放出错时不自动切换";
            cbStopPlayingWhenError.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(numTimeOut);
            groupBox4.Controls.Add(numNetBuffer);
            groupBox4.Controls.Add(numPlayBuffer);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 203);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(337, 112);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "播放";
            // 
            // numTimeOut
            // 
            numTimeOut.DecimalPlaces = 0;
            numTimeOut.Dock = DockStyle.Top;
            numTimeOut.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numTimeOut.LabelAutoSize = true;
            numTimeOut.LabelText = "服务器连接超时(ms)";
            numTimeOut.LabelWidth = 119;
            numTimeOut.Location = new Point(3, 79);
            numTimeOut.Margin = new Padding(4, 4, 4, 4);
            numTimeOut.Maxinum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTimeOut.MinimumSize = new Size(0, 30);
            numTimeOut.Mininum = new decimal(new int[] { 1, 0, 0, 0 });
            numTimeOut.Name = "numTimeOut";
            numTimeOut.ReadOnly = false;
            numTimeOut.Size = new Size(331, 30);
            numTimeOut.TabIndex = 4;
            numTimeOut.Text = "1";
            numTimeOut.TextBoxBackColor = SystemColors.Window;
            numTimeOut.TextBoxForeColor = SystemColors.WindowText;
            numTimeOut.ThousandsSeparator = false;
            numTimeOut.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numNetBuffer
            // 
            numNetBuffer.DecimalPlaces = 0;
            numNetBuffer.Dock = DockStyle.Top;
            numNetBuffer.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numNetBuffer.LabelAutoSize = true;
            numNetBuffer.LabelText = "下载缓冲区长度(ms)";
            numNetBuffer.LabelWidth = 119;
            numNetBuffer.Location = new Point(3, 49);
            numNetBuffer.Margin = new Padding(4, 4, 4, 4);
            numNetBuffer.Maxinum = new decimal(new int[] { 100000, 0, 0, 0 });
            numNetBuffer.MinimumSize = new Size(0, 30);
            numNetBuffer.Mininum = new decimal(new int[] { 1, 0, 0, 0 });
            numNetBuffer.Name = "numNetBuffer";
            numNetBuffer.ReadOnly = false;
            numNetBuffer.Size = new Size(331, 30);
            numNetBuffer.TabIndex = 3;
            numNetBuffer.Text = "1";
            numNetBuffer.TextBoxBackColor = SystemColors.Window;
            numNetBuffer.TextBoxForeColor = SystemColors.WindowText;
            numNetBuffer.ThousandsSeparator = false;
            numNetBuffer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numPlayBuffer
            // 
            numPlayBuffer.DecimalPlaces = 0;
            numPlayBuffer.Dock = DockStyle.Top;
            numPlayBuffer.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayBuffer.LabelAutoSize = true;
            numPlayBuffer.LabelText = "播放缓冲区长度(ms)";
            numPlayBuffer.LabelWidth = 119;
            numPlayBuffer.Location = new Point(3, 19);
            numPlayBuffer.Margin = new Padding(4, 4, 4, 4);
            numPlayBuffer.Maxinum = new decimal(new int[] { 5000, 0, 0, 0 });
            numPlayBuffer.MinimumSize = new Size(0, 30);
            numPlayBuffer.Mininum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayBuffer.Name = "numPlayBuffer";
            numPlayBuffer.ReadOnly = false;
            numPlayBuffer.Size = new Size(331, 30);
            numPlayBuffer.TabIndex = 2;
            numPlayBuffer.Text = "1";
            numPlayBuffer.TextBoxBackColor = SystemColors.Window;
            numPlayBuffer.TextBoxForeColor = SystemColors.WindowText;
            numPlayBuffer.ThousandsSeparator = false;
            numPlayBuffer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(rbCoreMCI);
            groupBox5.Controls.Add(rbCoreBASS);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 315);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(337, 65);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "*播放内核";
            // 
            // rbCoreBASS
            // 
            rbCoreBASS.AutoSize = true;
            rbCoreBASS.Checked = true;
            rbCoreBASS.Location = new Point(6, 22);
            rbCoreBASS.Name = "rbCoreBASS";
            rbCoreBASS.Size = new Size(56, 21);
            rbCoreBASS.TabIndex = 0;
            rbCoreBASS.TabStop = true;
            rbCoreBASS.Text = "BASS";
            rbCoreBASS.UseVisualStyleBackColor = true;
            // 
            // rbCoreMCI
            // 
            rbCoreMCI.AutoSize = true;
            rbCoreMCI.Location = new Point(68, 22);
            rbCoreMCI.Name = "rbCoreMCI";
            rbCoreMCI.Size = new Size(50, 21);
            rbCoreMCI.TabIndex = 1;
            rbCoreMCI.Text = "MCI";
            rbCoreMCI.UseVisualStyleBackColor = true;
            // 
            // PlaySettingsPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PlaySettingsPage";
            Size = new Size(337, 410);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSampleRate).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbDevice;
        private NumericUpDown nudSampleRate;
        private GroupBox groupBox2;
        private WinFormsExtendedControls.FilePanel.OpenFilePanel tbMIDISoundFont;
        private GroupBox groupBox3;
        private CheckBox cbStopPlayingWhenError;
        private WinFormsExtendedControls.LabeledNumericUpDown numMIDIVoices;
        private GroupBox groupBox4;
        private WinFormsExtendedControls.LabeledNumericUpDown numPlayBuffer;
        private WinFormsExtendedControls.LabeledNumericUpDown numNetBuffer;
        private WinFormsExtendedControls.LabeledNumericUpDown numTimeOut;
        private GroupBox groupBox5;
        private RadioButton rbCoreMCI;
        private RadioButton rbCoreBASS;
    }
}
