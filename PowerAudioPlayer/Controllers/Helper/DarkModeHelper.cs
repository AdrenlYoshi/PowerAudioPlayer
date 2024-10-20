using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace PowerAudioPlayer.Controllers.Helper
{
    public class DarkIconHelper
    {
        public Form OwnerForm { get; set; }

        public bool IsDarkMode { get; set; } = false;

        public bool forceProcessing = true;

        public DarkIconHelper(Form form)
        {
            OwnerForm = form;
        }

        #region Public Methods
        public void ApplyTheme(bool pIsDarkMode = true)
        {
            if (!forceProcessing)
               return;
            IsDarkMode = pIsDarkMode;
            try
            {

                if (OwnerForm != null && OwnerForm.Controls != null)
                {
                    foreach (Control _control in OwnerForm.Controls)
                    {
                        ThemeControl(_control);
                    }

                    OwnerForm.ControlAdded += (object sender, ControlEventArgs e) =>
                    {
                        ThemeControl(e.Control);
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                forceProcessing = false;
            }
        }

        public void ThemeControl(Control control)
        {
            control.ControlAdded += (object? sender, ControlEventArgs e) =>
            {
                ThemeControl(e.Control);
            };
            if (IsDarkMode)
            {
                if (control is MenuStrip)
                {
                    (control as MenuStrip).RenderMode = ToolStripRenderMode.Professional;
                    (control as MenuStrip).Renderer = new MyRenderer();
                }
                if (control is ToolStrip)
                {
                    (control as ToolStrip).RenderMode = ToolStripRenderMode.Professional;
                    (control as ToolStrip).Renderer = new MyRenderer();
                }
                if (control is ToolStripDropDown)
                {
                    (control as ToolStripDropDown).Opening += Tsdd_Opening;
                }
                if (control is ToolStripDropDownMenu)
                {
                    (control as ToolStripDropDownMenu).Opening += Tsdd_Opening;
                }
                if (control is ContextMenuStrip)
                {
                    (control as ContextMenuStrip).RenderMode = ToolStripRenderMode.Professional;
                    (control as ContextMenuStrip).Renderer = new MyRenderer();
                    (control as ContextMenuStrip).Opening += Tsdd_Opening;
                }
            }
            else
            {
                if (control is MenuStrip)
                {
                    //(control as MenuStrip).RenderMode = ToolStripRenderMode.ManagerRenderMode;
                    (control as MenuStrip).Renderer = null;
                }
                if (control is ToolStrip)
                {
                    //(control as MenuStrip).RenderMode = ToolStripRenderMode.ManagerRenderMode;
                    (control as ToolStrip).Renderer = null;
                }
                if (control is ToolStripDropDown)
                {
                    (control as ToolStripDropDown).Opening -= Tsdd_Opening;
                }
                if (control is ToolStripDropDownMenu)
                {
                    (control as ToolStripDropDownMenu).Opening -= Tsdd_Opening;
                }
                if (control is ContextMenuStrip)
                {
                    //(control as MenuStrip).RenderMode = ToolStripRenderMode.ManagerRenderMode;
                    (control as ContextMenuStrip).Renderer = null;
                    (control as ContextMenuStrip).Opening -= Tsdd_Opening;
                }
            }
            //Debug.WriteLine(string.Format("{0}: {1}", control.Name, control.GetType().Name));

            if (control.ContextMenuStrip != null)
                ThemeControl(control.ContextMenuStrip);

            foreach (Control childControl in control.Controls)
            {
                ThemeControl(childControl);
            }
        }

        public static Bitmap ChangeToColor(Bitmap bmp)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(bmp2))
            {
                System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
                {
                    [-1, 0, 0, 0, 0],
                    [0, -1, 0, 0, 0],
                    [0, 0, -1, 0, 0],
                    [0, 0, 0, 1, 0],
                    [1, 1, 1, 0, 1]
                });
                System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
                g.DrawString("RENDER", new Font("SimSun", 9), Brushes.Red, 0, 0);
            }
            return bmp2;
        }
        public static Image ChangeToColor(Image bmp) => ChangeToColor((Bitmap)bmp);

        #endregion Public Methods

        #region Private Methods
        private void Tsdd_Opening(object? sender, CancelEventArgs e)
        {
            ToolStripDropDown tsdd = sender as ToolStripDropDown;
            if (tsdd == null) return;

            foreach (ToolStripMenuItem toolStripMenuItem in tsdd.Items.OfType<ToolStripMenuItem>())
            {
                toolStripMenuItem.DropDownOpening += Tsmi_DropDownOpening;
            }
        }

        private void Tsmi_DropDownOpening(object? sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            if (tsmi == null) return;

            if (tsmi.DropDown.Items.Count > 0) ThemeControl(tsmi.DropDown);
            tsmi.DropDownOpening -= Tsmi_DropDownOpening;
        }
        #endregion Private Methods
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer()
        {
        }

        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            if (e.Item.GetType().FullName == "System.Windows.Forms.MdiControlStrip+ControlBoxMenuItem" && !(e.Item.Tag != null && ((string)e.Item.Tag).Contains("IgnoreColorize")))
            {
                Image? image = e.Image;
                using (Image adjustedImage = DarkIconHelper.ChangeToColor(image))
                {
                    e.Graphics.DrawImage(adjustedImage, e.ImageRectangle);
                }

                return;
            }

            if (e.Image != null && !(e.Item.Tag != null && ((string)e.Item.Tag).Contains("IgnoreColorize")))
            {
                Image image = e.Image;
                using (Image adjustedImage = DarkIconHelper.ChangeToColor(image))
                {
                    e.Graphics.DrawImage(adjustedImage, e.ImageRectangle);
                }
            }
            else
            {
                base.OnRenderItemImage(e);
            }
        }
    }
}
