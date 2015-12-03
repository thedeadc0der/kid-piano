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
        // Appearance
        private int keyLength_;
        private int startOctave_;
        private bool showNotes_;

        // Behavior
        LinkedList<Note> pressedKeys_;

        public int KeyLength
        {
            get { return keyLength_; }
            set { keyLength_ = value; }
        }

        public PianoControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw   = true;
            this.KeyLength      = 24;
            this.showNotes_     = true;
            this.startOctave_   = 3;
            this.pressedKeys_   = new LinkedList<Note>();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush blackBrush = new SolidBrush(Color.Black),
                  whiteBrush = new SolidBrush(Color.White),
                  grayBrush = new SolidBrush(Color.DarkGray),
                  gutterBrush = new SolidBrush(Color.FromArgb(0x20, 0x20, 0x20)),
                  pressedBrush = new SolidBrush(Color.Red);

            int kActualKeyLength = KeyLength + 1;
            int kNumberOfKeys = ClientRectangle.Width / kActualKeyLength + 1;

            Note currentNote;

            // Draw the white keys
            currentNote = new Note(NomNote.Do, startOctave_);
            for ( int i=0; i < kNumberOfKeys; ++i, currentNote = currentNote.next())
            {
                int xStart = kActualKeyLength * i,
                    xEnd = kActualKeyLength * (i + 1) - 1,
                    xBlackStart = xEnd - (KeyLength / 2),
                    blackHeight = (2 * ClientRectangle.Height) / 3;

                Brush noteBrush = whiteBrush;

                if( pressedKeys_.Find(currentNote) != null )
                    noteBrush = pressedBrush;

                Rectangle thisKey = new Rectangle(xStart, 0, KeyLength, ClientRectangle.Height),
                          border = new Rectangle(xEnd, 0, 1, ClientRectangle.Height);

                e.Graphics.FillRectangle(noteBrush, thisKey);
                e.Graphics.FillRectangle(grayBrush, border);
            }

            // Draw the black keys
            currentNote = new Note(NomNote.Do, startOctave_);
            for ( int i=0; i < kNumberOfKeys; ++i, currentNote = currentNote.next()){
                // Only draw black keys where they exist
                if (!currentNote.hasBlack() )
                    continue;

                int xEnd = kActualKeyLength * (i+1),
                    blackLength = (2 * kActualKeyLength) / 3,
                    xBlackStart = xEnd - (blackLength / 2),
                    blackHeight = (2 * ClientRectangle.Height) / 3;

                Brush noteBrush = blackBrush;

                if( pressedKeys_.Find(currentNote.getBlackOf()) != null )
                    noteBrush = pressedBrush;

                Rectangle blackKey = new Rectangle(xBlackStart, 0, blackLength, blackHeight);
                e.Graphics.FillRectangle(noteBrush, blackKey);
            }

            // Draw the gutter
            if ( showNotes_){
                Rectangle gutter = new Rectangle(0, 0, ClientRectangle.Width, 18 );
                e.Graphics.FillRectangle(gutterBrush, gutter);

                Font font = new Font("Monospace", 8);
                SolidBrush brush = new SolidBrush(Color.White);
                StringFormat format = new StringFormat();
                float x, y = 2.0F;

                currentNote = new Note(NomNote.Do, startOctave_);
                for ( int i=0; i < kNumberOfKeys; ++i, currentNote = currentNote.next()){
                    String toDraw = currentNote.ToString();
                    SizeF size = e.Graphics.MeasureString(toDraw, font);

                    x = (float)kActualKeyLength * i;
                    x += ((float)kActualKeyLength - size.Width) / 2.0F;

                    e.Graphics.DrawString(currentNote.ToString(), font, brush, x, y, format);
                }
            }
        }

        private Note getNoteFromKey( Keys k )
        {
            NomNote nom = NomNote.Invalide;
            int octave = 0;

            switch( k)
            {
                case Keys.Q: nom = NomNote.Do; break;
                case Keys.Z: nom = NomNote.DoDiese; break;
                case Keys.S: nom = NomNote.Re; break;
                case Keys.E: nom = NomNote.ReDiese; break;
                case Keys.D: nom = NomNote.Mi; break;
                case Keys.F: nom = NomNote.Fa; break;
                case Keys.T: nom = NomNote.FaDiese; break;
                case Keys.G: nom = NomNote.Sol; break;
                case Keys.Y: nom = NomNote.SolDiese; break;
                case Keys.H: nom = NomNote.La; break;
                case Keys.U: nom = NomNote.LaDiese; break;
                case Keys.J: nom = NomNote.Si; break;
                case Keys.K: nom = NomNote.Do; octave = 1; break;
                case Keys.O: nom = NomNote.DoDiese; octave = 1; break;
                case Keys.L: nom = NomNote.Re; octave = 1; break;
                case Keys.P: nom = NomNote.ReDiese; octave = 1; break;
                case Keys.M: nom = NomNote.Mi; octave = 1; break;
            }

            if (nom == NomNote.Invalide)
                return null;

            return new Note(nom, startOctave_ + octave);
        }
        
        private void addNote( Note n){
            if (n == null)
                return;

            if( pressedKeys_.Find(n) == null){
                pressedKeys_.AddLast(n);
                Invalidate();
            }
        }

        private void removeNote( Note n){
            if (n != null){
                pressedKeys_.Remove(n);
                Invalidate();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e){
            base.OnKeyDown(e);
            addNote( getNoteFromKey(e.KeyCode) );
        }

        protected override void OnKeyUp(KeyEventArgs e){
            base.OnKeyUp(e);
            removeNote(getNoteFromKey(e.KeyCode));
        }

        private NomNote getNameFromIndex( int index){
            switch( index ){
                case 1: return NomNote.Do;
                case 2: return NomNote.Re;
                case 3: return NomNote.Mi;
                case 4: return NomNote.Fa;
                case 5: return NomNote.Sol;
                case 6: return NomNote.La;
                case 0: return NomNote.Si;
                default: return NomNote.Invalide;
            }
        }

        private Note getNoteFromMouse( Point p ){
            int kActualKeyLength = KeyLength + 1,
                key = p.X / kActualKeyLength + 1,
                index = key % 7,
                octave = key / 7;

            if (index == 0)
                octave--;

            return new Note(getNameFromIndex(index), octave + startOctave_);
        }

        protected override void OnMouseDown(MouseEventArgs e){
            base.OnMouseDown(e);
            addNote(getNoteFromMouse(e.Location));
        }

        protected override void OnMouseUp(MouseEventArgs e){
            base.OnMouseUp(e);
            removeNote(getNoteFromMouse(e.Location));
        }
    }
}
