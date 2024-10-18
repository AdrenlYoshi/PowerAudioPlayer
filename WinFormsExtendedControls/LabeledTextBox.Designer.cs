using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    partial class LabeledTextBox
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
            comboBox = new ComboBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Dock = DockStyle.Left;
            label.Location = new Point(15, 0);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Padding = new Padding(2, 6, 0, 0);
            label.Size = new Size(38, 23);
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
            chkBox.Margin = new Padding(4, 4, 4, 4);
            chkBox.Name = "chkBox";
            chkBox.Size = new Size(15, 30);
            chkBox.TabIndex = 2;
            chkBox.UseVisualStyleBackColor = true;
            chkBox.Visible = false;
            chkBox.CheckedChanged += chkBox_CheckedChanged;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(298, 1);
            comboBox.Margin = new Padding(2, 3, 2, 3);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(53, 25);
            comboBox.TabIndex = 3;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // LabeledTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox);
            Controls.Add(label);
            Controls.Add(chkBox);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(0, 30);
            Name = "LabeledTextBox";
            Size = new Size(374, 30);
            SizeChanged += LabeledTextBox_SizeChanged;
            VisibleChanged += LabeledTextBox_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label;
        private HintedTextBox textbox;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.ComboBox comboBox;
    }
}
