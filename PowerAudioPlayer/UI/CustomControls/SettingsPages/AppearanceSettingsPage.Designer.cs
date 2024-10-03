namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    partial class AppearanceSettingsPage
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
            groupBox4 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cpSpectrumColorFalloff = new WinFormsExtendedControls.ColorPicker();
            label8 = new Label();
            cpSpectrumGridColor = new WinFormsExtendedControls.ColorPicker();
            cpSpectrumNormalColor = new WinFormsExtendedControls.ColorPicker();
            cpSpectrumMediumColor = new WinFormsExtendedControls.ColorPicker();
            label4 = new Label();
            cpSpectrumHighColor = new WinFormsExtendedControls.ColorPicker();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbSpectrumFalloff = new CheckBox();
            cbSpectrumWithGrid = new CheckBox();
            cbSpectrumDisable = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            nudLyricsItemsMargin = new NumericUpDown();
            cpLyricsHighlightColor = new WinFormsExtendedControls.ColorPicker();
            label2 = new Label();
            label5 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLyricsItemsMargin).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(tableLayoutPanel1);
            groupBox4.Controls.Add(cbSpectrumFalloff);
            groupBox4.Controls.Add(cbSpectrumWithGrid);
            groupBox4.Controls.Add(cbSpectrumDisable);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(480, 230);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "频谱";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cpSpectrumColorFalloff, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(cpSpectrumGridColor, 1, 3);
            tableLayoutPanel1.Controls.Add(cpSpectrumNormalColor, 1, 2);
            tableLayoutPanel1.Controls.Add(cpSpectrumMediumColor, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(cpSpectrumHighColor, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(474, 145);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // cpSpectrumColorFalloff
            // 
            cpSpectrumColorFalloff.BackColor = Color.White;
            cpSpectrumColorFalloff.Color = Color.White;
            cpSpectrumColorFalloff.Dock = DockStyle.Fill;
            cpSpectrumColorFalloff.Location = new Point(77, 119);
            cpSpectrumColorFalloff.Name = "cpSpectrumColorFalloff";
            cpSpectrumColorFalloff.Size = new Size(394, 23);
            cpSpectrumColorFalloff.TabIndex = 12;
            cpSpectrumColorFalloff.Text = "colorPicker1";
            cpSpectrumColorFalloff.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 122);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 11;
            label8.Text = "下落效果";
            // 
            // cpSpectrumGridColor
            // 
            cpSpectrumGridColor.BackColor = Color.White;
            cpSpectrumGridColor.Color = Color.White;
            cpSpectrumGridColor.Dock = DockStyle.Fill;
            cpSpectrumGridColor.Location = new Point(77, 90);
            cpSpectrumGridColor.Name = "cpSpectrumGridColor";
            cpSpectrumGridColor.Size = new Size(394, 23);
            cpSpectrumGridColor.TabIndex = 10;
            cpSpectrumGridColor.Text = "colorPicker1";
            cpSpectrumGridColor.UseVisualStyleBackColor = true;
            // 
            // cpSpectrumNormalColor
            // 
            cpSpectrumNormalColor.BackColor = Color.White;
            cpSpectrumNormalColor.Color = Color.White;
            cpSpectrumNormalColor.Dock = DockStyle.Fill;
            cpSpectrumNormalColor.Location = new Point(77, 61);
            cpSpectrumNormalColor.Name = "cpSpectrumNormalColor";
            cpSpectrumNormalColor.Size = new Size(394, 23);
            cpSpectrumNormalColor.TabIndex = 9;
            cpSpectrumNormalColor.Text = "colorPicker1";
            cpSpectrumNormalColor.UseVisualStyleBackColor = true;
            // 
            // cpSpectrumMediumColor
            // 
            cpSpectrumMediumColor.BackColor = Color.White;
            cpSpectrumMediumColor.Color = Color.White;
            cpSpectrumMediumColor.Dock = DockStyle.Fill;
            cpSpectrumMediumColor.Location = new Point(77, 32);
            cpSpectrumMediumColor.Name = "cpSpectrumMediumColor";
            cpSpectrumMediumColor.Size = new Size(394, 23);
            cpSpectrumMediumColor.TabIndex = 8;
            cpSpectrumMediumColor.Text = "colorPicker1";
            cpSpectrumMediumColor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 35);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 5;
            label4.Text = "频谱中颜色";
            // 
            // cpSpectrumHighColor
            // 
            cpSpectrumHighColor.BackColor = Color.White;
            cpSpectrumHighColor.Color = Color.White;
            cpSpectrumHighColor.Dock = DockStyle.Fill;
            cpSpectrumHighColor.Location = new Point(77, 3);
            cpSpectrumHighColor.Name = "cpSpectrumHighColor";
            cpSpectrumHighColor.Size = new Size(394, 23);
            cpSpectrumHighColor.TabIndex = 3;
            cpSpectrumHighColor.Text = "colorPicker1";
            cpSpectrumHighColor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 4;
            label1.Text = "频谱高颜色";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 64);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 6;
            label6.Text = "频谱低颜色";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 93);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 7;
            label7.Text = "网格颜色";
            // 
            // cbSpectrumFalloff
            // 
            cbSpectrumFalloff.AutoSize = true;
            cbSpectrumFalloff.Dock = DockStyle.Top;
            cbSpectrumFalloff.Location = new Point(3, 61);
            cbSpectrumFalloff.Name = "cbSpectrumFalloff";
            cbSpectrumFalloff.Size = new Size(474, 21);
            cbSpectrumFalloff.TabIndex = 13;
            cbSpectrumFalloff.Text = "下落效果";
            cbSpectrumFalloff.UseVisualStyleBackColor = true;
            // 
            // cbSpectrumWithGrid
            // 
            cbSpectrumWithGrid.AutoSize = true;
            cbSpectrumWithGrid.Dock = DockStyle.Top;
            cbSpectrumWithGrid.Location = new Point(3, 40);
            cbSpectrumWithGrid.Name = "cbSpectrumWithGrid";
            cbSpectrumWithGrid.Size = new Size(474, 21);
            cbSpectrumWithGrid.TabIndex = 12;
            cbSpectrumWithGrid.Text = "显示网格";
            cbSpectrumWithGrid.UseVisualStyleBackColor = true;
            // 
            // cbSpectrumDisable
            // 
            cbSpectrumDisable.AutoSize = true;
            cbSpectrumDisable.Dock = DockStyle.Top;
            cbSpectrumDisable.Location = new Point(3, 19);
            cbSpectrumDisable.Name = "cbSpectrumDisable";
            cbSpectrumDisable.Size = new Size(474, 21);
            cbSpectrumDisable.TabIndex = 11;
            cbSpectrumDisable.Text = "禁用频谱";
            cbSpectrumDisable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 80);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "歌词";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(nudLyricsItemsMargin, 1, 1);
            tableLayoutPanel5.Controls.Add(cpLyricsHighlightColor, 1, 0);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(474, 58);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // nudLyricsItemsMargin
            // 
            nudLyricsItemsMargin.Dock = DockStyle.Fill;
            nudLyricsItemsMargin.Location = new Point(65, 32);
            nudLyricsItemsMargin.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudLyricsItemsMargin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLyricsItemsMargin.Name = "nudLyricsItemsMargin";
            nudLyricsItemsMargin.Size = new Size(406, 23);
            nudLyricsItemsMargin.TabIndex = 5;
            nudLyricsItemsMargin.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudLyricsItemsMargin.ValueChanged += nudLyricsItemsMargin_ValueChanged;
            // 
            // cpLyricsHighlightColor
            // 
            cpLyricsHighlightColor.BackColor = Color.White;
            cpLyricsHighlightColor.Color = Color.White;
            cpLyricsHighlightColor.Dock = DockStyle.Fill;
            cpLyricsHighlightColor.Location = new Point(65, 3);
            cpLyricsHighlightColor.Name = "cpLyricsHighlightColor";
            cpLyricsHighlightColor.Size = new Size(406, 23);
            cpLyricsHighlightColor.TabIndex = 3;
            cpLyricsHighlightColor.Text = "colorPicker1";
            cpLyricsHighlightColor.UseVisualStyleBackColor = true;
            cpLyricsHighlightColor.ColorChanged += cpLyricsNormalColor_ColorChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 4;
            label2.Text = "高亮颜色";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 35);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 1;
            label5.Text = "间距";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(474, 0);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(474, 0);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(474, 0);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // AppearanceSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Name = "AppearanceSettingsPage";
            Size = new Size(480, 444);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLyricsItemsMargin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private CheckBox cbSpectrumHighQuality;
        private CheckBox cbSpectrumFull;
        private CheckBox cbSpectrumWithGrid;
        private CheckBox cbSpectrumDisable;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private WinFormsExtendedControls.ColorPicker cpLyricsHighlightColor;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown nudLyricsItemsMargin;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel1;
        private WinFormsExtendedControls.ColorPicker cpSpectrumColorFalloff;
        private Label label8;
        private WinFormsExtendedControls.ColorPicker cpSpectrumGridColor;
        private WinFormsExtendedControls.ColorPicker cpSpectrumNormalColor;
        private WinFormsExtendedControls.ColorPicker cpSpectrumMediumColor;
        private Label label4;
        private WinFormsExtendedControls.ColorPicker cpSpectrumHighColor;
        private Label label1;
        private Label label6;
        private Label label7;
        private CheckBox cbSpectrumFalloff;
    }
}
