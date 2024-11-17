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
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            nudLyricsItemsMargin = new NumericUpDown();
            cpLyricsHighlightColor = new WinFormsExtendedControls.ColorPicker();
            label2 = new Label();
            label5 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLyricsItemsMargin).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
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
            Name = "AppearanceSettingsPage";
            Size = new Size(480, 444);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLyricsItemsMargin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbSpectrumHighQuality;
        private CheckBox cbSpectrumFull;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private WinFormsExtendedControls.ColorPicker cpLyricsHighlightColor;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown nudLyricsItemsMargin;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
    }
}
