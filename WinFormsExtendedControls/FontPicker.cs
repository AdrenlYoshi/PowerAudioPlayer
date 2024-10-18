using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    [DefaultEvent("SelectedFontChange")]
    public class FontPicker : Button
    {
        public event EventHandler? SelectedFontChanged;
        private Font _font;
        public Font SelectedFont
        {
            get { return _font; }
            set { _font = value; base.Font = value; base.Text = FontToString(_font); }
        }

        [DefaultValue("")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text
        {
            get => base.Text;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Font Font
        {
            get => base.Font;
        }

        public FontPicker()
        {
            _font = base.Font;
            base.Text = FontToString(_font);
        }

        protected override void OnClick(EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = _font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                base.Font = _font = fontDialog.Font;
                base.Text = FontToString(_font);
                SelectedFontChanged?.Invoke(this, EventArgs.Empty);
            }
            base.OnClick(e);
        }

        private string FontToString(Font font) 
        {
            return string.Format("{0}, {1}", font.Name, font.Size);
        }
    }
}