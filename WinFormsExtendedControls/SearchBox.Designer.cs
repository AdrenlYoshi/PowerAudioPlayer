using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    partial class SearchBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBox));
            tbSearch = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearch = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Dock = DockStyle.Top;
            tbSearch.Location = new Point(3, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(157, 23);
            tbSearch.TabIndex = 0;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel1.Controls.Add(tbSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(219, 30);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(194, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(22, 22);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Dock = DockStyle.Top;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(166, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(22, 22);
            btnClear.TabIndex = 1;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // SearchBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SearchBox";
            Size = new Size(219, 30);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSearch;
        private Button btnClear;
    }
}
