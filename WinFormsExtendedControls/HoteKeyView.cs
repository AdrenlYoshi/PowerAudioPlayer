using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WinFormsExtendedControls
{
    public class HoteKeyView : TextBox
    {

        public HoteKeyView() 
        {
            ReadOnly = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            StringBuilder keyValue = new StringBuilder();
            keyValue.Length = 0;
            keyValue.Append("");
            if (e.Modifiers != 0)
            {
                if (e.Control)
                    keyValue.Append("Ctrl + ");
                if (e.Alt)
                    keyValue.Append("Alt + ");
                if (e.Shift)
                    keyValue.Append("Shift + ");
            }
            if ((e.KeyValue >= 33 && e.KeyValue <= 40) ||
                (e.KeyValue >= 65 && e.KeyValue <= 90) ||   //a-z/A-Z
                (e.KeyValue >= 112 && e.KeyValue <= 123))   //F1-F12
            {
                keyValue.Append(e.KeyCode);
            }
            else if (e.KeyValue >= 48 && e.KeyValue <= 57)    //0-9
            {
                keyValue.Append(e.KeyCode.ToString().Substring(1));
            }
            Text = string.Empty;
            //设置当前活动控件的文本内容
            Text = keyValue.ToString();
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            string str = Text.TrimEnd();
            int len = str.Length;
            if (len >= 1 && str.Substring(str.Length - 1) == "+")
            {
                Text = string.Empty;
            }
            base.OnKeyUp(e);
        }
    }
}
