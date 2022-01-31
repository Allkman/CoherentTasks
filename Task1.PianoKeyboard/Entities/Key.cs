using Task1.PianoKeyboard.Enums;

namespace Task1.PianoKeyboard.Entities
{
    internal struct Key : IComparable<Key>
    {
        private readonly Accidental _accidental;
        private readonly Octave _octave;
        private readonly Note _note;
        public Key(Note note, Accidental accidental, Octave octave)
        {
            _note = note;
            _accidental = accidental;
            _octave = octave;
        }
        public override string ToString()
        {
            return $"In {_octave} octave. Note: {_note} {_accidental}";
        }
        public int CompareTo(Key other)
        {
            //should I implement logic for 2 first Keys from SubContra and 1 last Key from Fifth octaves?
            if (this._octave == Octave.SubContra && other._octave == Octave.SubContra)
            {
                return ComparingNotesOfSubContraOctave(other);
            }
            if (this._octave == Octave.Fifth && this._note == Note.C &&
                other._octave == Octave.Fifth && other._note == Note.C)
            {
                return ComparingNoteOfFifthOctave(other);
            }
            //checking if comparable keys are in the same octave OR || if they are in two neighboring octaves && 
            if ((this._octave == other._octave || this._octave - other._octave == -1) &&
                //if notes have black Key between them OR || no black Key OR || notes are from neighboring octaves
                (this._note - other._note == -2 || this._note - other._note == -1 || this._note - other._note == 11))
            {
                //if Key is black its == 2 OR || 
                if (this._accidental - other._accidental == 2 ||
                    //if there is no Key between its == 1
                    this._accidental - other._accidental == 1) return 0;
                return 1;
            }
            return 1;
        }
        private readonly int ComparingNoteOfFifthOctave(Key other)
        {
            if (other._octave == Octave.Fifth && other._note == Note.C)
            {
                if (other._accidental == Accidental.Sharp)
                {
                    Console.WriteLine("C8 is 88th Key, it cannot have Sharp Accidental");
                }
                if (this._accidental - other._accidental == 0) return 0;
                else Console.WriteLine("Cannot compare non existing Key");
            }
            return 1;
        }
        private readonly int ComparingNotesOfSubContraOctave(Key other)
        {
            if (this._note == Note.A && other._note == Note.B)
            {
                if (this._accidental - other._accidental == 2) return 0;
            }
            else Console.WriteLine("Cannot compare non existing Key");

            return 1;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            } 
            return this.CompareTo((Key)obj) == 0;
        }
    }
}
