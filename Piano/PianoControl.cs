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
        private int keyLength_;
        private int startOctave_;
        private bool showNotes_;

        public int KeyLength
        {
            get { return keyLength_; }
            set { keyLength_ = value; }
        }

        public PianoControl()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            this.KeyLength = 24;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush blackBrush = new SolidBrush(Color.Black),
                  whiteBrush = new SolidBrush(Color.White),
                  grayBrush = new SolidBrush(Color.LightGray);

            int kActualKeyLength = KeyLength + 1;
            int kNumberOfKeys = ClientRectangle.Width / kActualKeyLength + 1;

            // Draw the white keys
            for ( int i=0; i < kNumberOfKeys; ++i){
                int xStart = kActualKeyLength * i,
                    xEnd = kActualKeyLength * (i + 1),
                    xBlackStart = xEnd - (KeyLength / 2),
                    blackHeight = (2 * ClientRectangle.Height) / 3;


                Rectangle thisKey = new Rectangle(xStart, 0, KeyLength, ClientRectangle.Height),
                          border = new Rectangle(xEnd, 0, 1, ClientRectangle.Height);

                e.Graphics.FillRectangle(whiteBrush, thisKey);
                e.Graphics.FillRectangle(grayBrush, border);
            }

            // Draw the black keys
            for( int i=0; i < kNumberOfKeys; ++i){
                int index = (i + 1) % 7;

                if (index == 0 || index == 3)
                    continue;

                int xEnd = kActualKeyLength * (i+1),
                    blackLength = (2 * kActualKeyLength) / 3,
                    xBlackStart = xEnd - (blackLength / 2),
                    blackHeight = (2 * ClientRectangle.Height) / 3;

                Rectangle blackKey = new Rectangle(xBlackStart, 0, blackLength, blackHeight);
                e.Graphics.FillRectangle(blackBrush, blackKey);
            }
        }


    }
}
