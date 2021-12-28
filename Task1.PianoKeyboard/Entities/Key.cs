using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.PianoKeyboard.Enums;

namespace Task1.PianoKeyboard.Entities
{
    internal class Key: IComparable<Key>
    {
        public EAccidental Accidental { get; set; }
        public ENote Note { get; set; }
        public EOctave Octave { get; set; }

        public Key(EAccidental accidental, ENote note, EOctave octave)
        {
            Accidental = accidental;
            Note = note;
            Octave = octave;
        }

        public int CompareTo(Key? other)
        {
            throw new NotImplementedException();
        }
    }
}
