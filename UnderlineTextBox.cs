using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added
using System.Windows.Forms;  // Added

namespace system_analysis
{
    public class UnderlineTextBox : TextBox  // Changed
    {
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf)
            {
                using (var graphics = this.CreateGraphics())
                {
                    using (var p = new Pen(Color.Black, 2))
                    {
                        graphics.DrawLine(p, new Point(0, this.Height - 2), new Point(this.Width, this.Height - 2));
                    }
                }
            }
        }
    }
}