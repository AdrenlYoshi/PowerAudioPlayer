using System.ComponentModel;
using System.Drawing.Imaging;

namespace PowerAudioPlayer.UI.CustomControls
{
    [ProvideProperty("RenderIt", typeof(ToolStripItem))]
    public class ToolDescribe : Component, IExtenderProvider
    {
        readonly Dictionary<ToolStripItem, bool> dic;

        public ToolDescribe()
        {
            dic = new Dictionary<ToolStripItem, bool>();
        }

        [DefaultValue(true)]
        public bool GetRenderIt(ToolStripItem item)
        {
            dic.TryGetValue(item, out bool value);
            return value;
        }

        public void SetRenderIt(ToolStripItem item, bool value)
        {
            if (item == null) 
            {
                return; 
            }

            if (!value)
            {
                dic.Remove(item);
                item.Paint -= Item_Paint;
            }
            else
            {
                if (!dic.ContainsKey(item))
                {
                    item.Paint += Item_Paint;
                }
                dic[item] = value;
            }
        }

        private void Item_Paint(object? sender, PaintEventArgs e)
        {
            Image im = ((ToolStripItem)sender).Image;
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                [-1, 0, 0, 0, 0],
                [0, -1, 0, 0, 0],
                [0, 0, -1, 0, 0],
                [0, 0, 0, 1, 0],
                [1, 1, 1, 0, 1]
            });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);
            e.Graphics.Clear(((ToolStripItem)sender).BackColor);
            e.Graphics.DrawImage(im, new Rectangle(0, 0, im.Width, im.Height), 0, 0, im.Width, im.Height, GraphicsUnit.Pixel, attributes);
        }

        public bool CanExtend(object extendee)
        {
            return true;
        }
    }
}