using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    enum NomNote
    {
        Do, DoDiese,
        Re, ReDiese,
        Mi,
        Fa, FaDiese,
        Sol, SolDiese,
        La, LaDiese
            Si
    }

    class Note
    {
        private NomNote nom_;
        private int octave_;

        public Note( NomNote nom, int octave)
        {
            this.nom_ = nom;
            this.octave_ = octave;
        }

        public NomNote Nom
        {
            get { return nom_; }
            set { nom_ = value; }
        }

        public int Octave
        {
            get { return octave_; }
            set { octave_ = value; }
        }
    }
}
