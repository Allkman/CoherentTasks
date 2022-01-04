using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.PianoKeyboard.Enums;

namespace Task1.PianoKeyboard.Entities
{
    internal struct Key : IComparable<Key>
    {
        private EAccidental _accidental;
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
            if (this._octave - other._octave < -1) return 1;
            if (this._octave - other._octave > 1) return -1;
            // when two NEIGHBOUR octave NOTES (B and C) are compared
            if (this._octave - other._octave == -1 || this._octave - other._octave == 1)
            {
                //                  B  from lower octave  follows C         
                if (this._note == ENote.B && other._note == ENote.C ||
                    // or when I compare C   from upper octave to  B
                    this._note == ENote.C && other._note == ENote.B)
                {
                    if (this._accidental - other._accidental == 0 ||
                        this._accidental - other._accidental == -2 ||
                        this._accidental == EAccidental.Flat) return 1;
                    if (this._accidental - other._accidental == 1 ||
                        this._accidental - other._accidental == -1) return 0;
                }
                return 1;
            }
            else
            {
                //           C   follows   D
                if ((this._note - other._note) == -1)
                {
                    if (this._accidental - other._accidental == 1 ||
                        this._accidental - other._accidental == -1 ||
                        this._accidental - other._accidental == -2) return 1;
                    // when its the same key!    
                    if (this._accidental - other._accidental == 2) return 0;
                    // when this.Note always precedes other.Note // although this can`t happen here
                }
                //          D   precedes   C
                if ((this._note - other._note) == 1)
                {
                    // when this.Note always precedes(KEY is on the RIGHT) the other.Note  
                    if (this._accidental - other._accidental == 0 ||
                        this._accidental - other._accidental == -1 ||
                        this._accidental - other._accidental == 1 ||
                        this._accidental - other._accidental == 2) return -1;
                    // when its the same key!    
                    if (this._accidental - other._accidental == -2) return 0;
                    // when this.Note always follows the other.Note // although this can`t happen here
                    return 1;
                }
                //         D  is the same  D
                if ((this._note - other._note) == 0)
                {
                    //when this.Note always follows(KEY is on the LEFT) the other.Note
                    if (this._accidental - other._accidental == -1 ||
                        this._accidental - other._accidental == -2) return 1;
                    //when this.Note always precedes(KEY is on the RIGHT) the other.Note
                    if (this._accidental - other._accidental == 1 ||
                        this._accidental - other._accidental == 2) return -1;
                    // when its the same key!
                    return 0;
                }
                //           D  follows    F
                if ((this._note - other._note) < -1) return 1;
                // F precedes  D
                return -1;
            }
        }
        public override bool Equals(object obj)
        {

            return this.CompareTo((Key)obj) == 0;
        }
    }
}
