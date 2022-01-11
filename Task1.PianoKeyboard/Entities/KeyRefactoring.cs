using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.PianoKeyboard.Enums;

namespace Task1.PianoKeyboard.Entities
{
    internal struct KeyRefactoring : IComparable<KeyRefactoring>
    {
        private readonly EAccidental _accidental;
        private readonly EOctave _octave;
        private readonly ENote _note;
        public KeyRefactoring(ENote note, EAccidental accidental, EOctave octave)
        {
            _note = note;
            _accidental = accidental;
            _octave = octave;
        }
        public override string ToString()
        {
            return $"In {_octave} octave. Note: {_note} {_accidental}";
        }
        public int CompareTo(KeyRefactoring other)
        {
            //checking if comparable keys are in the same octave || they are in two neighboring octaves && 
            if ((this._octave == other._octave || this._octave -other._octave == -1) &&
                //if they have black Key between them OR || no black Key
                (this._note - other._note == 2 || this._note - other._note == 1))
            {
                //if Key is black its == 2 OR || if there is no Key between its == 1
                if (this._accidental - other._accidental == 2 ||
                    this._accidental - other._accidental == 1) return 0;
                return 1;
            }
            return 1;
        }

        public override bool Equals(object obj)
        {
            return this.CompareTo((KeyRefactoring)obj) == 0;
        }
    }
}
