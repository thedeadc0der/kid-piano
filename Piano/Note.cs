using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    enum NomNote
    {
        Invalide,
        Do, DoDiese,
        Re, ReDiese,
        Mi,
        Fa, FaDiese,
        Sol, SolDiese,
        La, LaDiese,
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

        public Note next()
        {
            NomNote new_note = Nom; int new_octave = Octave;

            switch( Nom)
            {
                case NomNote.Do: new_note = NomNote.Re; break;
                case NomNote.Re: new_note = NomNote.Mi; break;
                case NomNote.Mi: new_note = NomNote.Fa; break;
                case NomNote.Fa: new_note = NomNote.Sol; break;
                case NomNote.Sol: new_note = NomNote.La; break;
                case NomNote.La: new_note = NomNote.Si; break;
                case NomNote.Si: new_note = NomNote.Do; new_octave++; break;
            }

            return new Note(new_note, new_octave);
        }

        public bool isBlack()
        {
            switch( Nom)
            {
                case NomNote.DoDiese:
                case NomNote.ReDiese:
                case NomNote.FaDiese:
                case NomNote.SolDiese:
                case NomNote.LaDiese:
                    return true;

                default:
                    return false;
            }
        }

        public bool isBlackOf( NomNote b )
        {
            if (Nom == NomNote.DoDiese && b == NomNote.Do)
                return true;

            if (Nom == NomNote.ReDiese && b == NomNote.Re)
                return true;

            if (Nom == NomNote.FaDiese && b == NomNote.Fa)
                return true;

            if (Nom == NomNote.SolDiese && b == NomNote.Sol)
                return true;

            if (Nom == NomNote.LaDiese && b == NomNote.La)
                return true;

            return false;
        }

        public bool hasBlack()
        {
            switch (Nom)
            {
                case NomNote.Do:
                case NomNote.Re:
                case NomNote.Fa:
                case NomNote.Sol:
                case NomNote.La:
                    return true;

                default:
                    return false;
            }
        }

        public Note getBlackOf()
        {
            NomNote nom = Nom;

            switch( Nom)
            {
                case NomNote.Do:  nom = NomNote.DoDiese; break;
                case NomNote.Re:  nom = NomNote.ReDiese; break;
                case NomNote.Fa:  nom = NomNote.FaDiese; break;
                case NomNote.Sol: nom = NomNote.SolDiese; break;
                case NomNote.La:  nom = NomNote.LaDiese; break;
            }

            return new Note(nom, Octave);
        }

        public bool isSameAs( Note o)
        {
            return (Nom == o.Nom) && (Octave == o.Octave);
        }

        public override bool Equals(object obj)
        {
            Note o = (Note)obj;
            return (Nom == o.Nom && Octave == o.Octave);
        }

        public override string ToString(){
            switch( Nom){
                case NomNote.Do: return "Do";
                case NomNote.Re: return "Ré";
                case NomNote.Mi: return "Mi";
                case NomNote.Fa: return "Fa";
                case NomNote.Sol: return "Sol";
                case NomNote.La: return "La";
                case NomNote.Si: return "Si";
                default: return "";
            }
        }
    }
}
