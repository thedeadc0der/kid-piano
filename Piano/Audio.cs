using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    class Audio
    {
        public Audio()
        {

        }

        public void JouerNote( Note note)
        {
            switch (note.Nom)
            {
                case NomNote.Do:using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\chimes.wav")){soundPlayer.Play();}; break;
                case NomNote.DoDiese: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.Fa: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.FaDiese: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.Invalide: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.La: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.LaDiese: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.Mi: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.Re: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.ReDiese: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.Si: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.Sol: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;
                case NomNote.SolDiese: using (var soundPlayer = new SoundPlayer()) { soundPlayer.Play(); }; break;

            }
    }
}
