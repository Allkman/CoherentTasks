using Task1.PianoKeyboard.Enums;

namespace Task1.PianoKeyboard.Entities
{
    internal struct Key : IComparable<Key>
    {
        private readonly EAccidental _accidental;
        private readonly EOctave _octave;
        private readonly ENote _note;
        public Key(ENote note, EAccidental accidental, EOctave octave)
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
            if (this._octave == EOctave.SubContra && other._octave == EOctave.SubContra)
            {
                return ComparingNotesOfSubContraOctave(other);
            }
            if (this._octave == EOctave.Fifth && this._note == ENote.C &&
                other._octave == EOctave.Fifth && other._note == ENote.C)
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
            if (other._octave == EOctave.Fifth && other._note == ENote.C)
            {
                if (other._accidental == EAccidental.Sharp)
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
            if (this._note == ENote.A && other._note == ENote.B)
            {
                if (this._accidental - other._accidental == 2) return 0;
            }
            else Console.WriteLine("Cannot compare non existing Key");

            return 1;
        }
        public override bool Equals(object obj)
        {
            return this.CompareTo((Key)obj) == 0;
        }
    }
}
