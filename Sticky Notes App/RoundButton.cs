using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sticky_Notes_App
{
    internal class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);
            if (this.Image != null)
            {
                int x = (this.Width - this.Image.Width) / 2;
                int y = (this.Height - this.Image.Height) / 2;
                pevent.Graphics.DrawImage(this.Image, x, y);
            }

        }
    }
}
