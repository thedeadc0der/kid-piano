using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class PianoControl : UserControl
    {
        public PianoControl()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(new SolidBrush(Color.Black), this.ClientRectangle);

            Font f = new Font("Arial", 16);
            e.Graphics.DrawString("<PIANO HERE>", f, new SolidBrush(Color.Black), new PointF( 0, 0 ) );
        }
    }
}
