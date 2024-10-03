namespace PowerAudioPlayer.UI
{
    partial class ExceptionForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            linkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBox, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(linkLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(518, 460);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox
            // 
            tableLayoutPanel1.SetColumnSpan(textBox, 2);
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(3, 54);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(512, 373);
            textBox.TabIndex = 2;
            textBox.WordWrap = false;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.DialogResult = DialogResult.OK;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 433);
            button1.Name = "button1";
            button1.Size = new Size(512, 24);
            button1.TabIndex = 3;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(45, 0);
            label1.Name = "label1";
            label1.Size = new Size(470, 34);
            label1.TabIndex = 0;
            label1.Text = "程序出现错误，即将关闭。请将下列文件和文本框内容发送给作者，以便排查错误。(注意：若下面的某些信息涉及你的隐私，请将其删除）";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Dock = DockStyle.Fill;
            linkLabel.Location = new Point(45, 34);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(470, 17);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "linkLabel1";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.ErrorBig;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new Size(32, 41);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ExceptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 460);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "ExceptionForm";
            Text = "程序错误";
            FormClosing += ExceptionForm_FormClosing;
            Load += ExceptionForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel linkLabel;
        private TextBox textBox;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}