using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    [DefaultEvent("ColorChange")]
    public class ColorPicker : Button
    {
        public event EventHandler? ColorChanged;
        private Color _color = Color.White;

        public Color Color
        {
            get { return _color; }
            set { _color = value; BackColor = value; }
        }

        [DefaultValue("")]
        public new string Text
        {
            get; set;
        } = string.Empty;

        public ColorPicker()
        {
        }

        protected override void OnClick(EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = _color;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = _color = colorDialog.Color;
                ColorChanged?.Invoke(this, EventArgs.Empty);
            }
            base.OnClick(e);
        }
    }
}