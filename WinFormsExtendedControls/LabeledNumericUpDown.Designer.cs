using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    partial class LabeledNumericUpDown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            chkBox = new CheckBox();
            textbox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)textbox).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = DockStyle.Left;
            label.Location = new Point(15, 0);
            label.Name = "label";
            label.Padding = new Padding(2, 4, 0, 0);
            label.Size = new Size(37, 16);
            label.TabIndex = 0;
            label.Text = "label";
            // 
            // chkBox
            // 
            chkBox.AutoSize = true;
            chkBox.Checked = true;
            chkBox.CheckState = CheckState.Checked;
            chkBox.Dock = DockStyle.Left;
            chkBox.Location = new Point(0, 0);
            chkBox.Name = "chkBox";
            chkBox.Size = new Size(15, 21);
            chkBox.TabIndex = 2;
            chkBox.UseVisualStyleBackColor = true;
            chkBox.Visible = false;
            chkBox.CheckedChanged += chkBox_CheckedChanged;
            // 
            // textbox
            // 
            textbox.AllowDrop = true;
            textbox.Dock = DockStyle.Fill;
            textbox.Location = new Point(52, 0);
            textbox.Name = "textbox";
            textbox.Size = new Size(324, 21);
            textbox.TabIndex = 1;
            textbox.TextChanged += textbox_TextChanged;
            textbox.DragDrop += textbox_DragDrop;
            textbox.DragEnter += textbox_DragEnter;
            textbox.KeyDown += textbox_KeyDown;
            textbox.KeyPress += textbox_KeyPress;
            // 
            // LabeledNumericUpDown
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textbox);
            Controls.Add(label);
            Controls.Add(chkBox);
            MinimumSize = new Size(0, 21);
            Name = "LabeledNumericUpDown";
            Size = new Size(376, 21);
            SizeChanged += LabeledTextBox_SizeChanged;
            VisibleChanged += LabeledTextBox_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)textbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown textbox;
        private System.Windows.Forms.CheckBox chkBox;
    }
}
