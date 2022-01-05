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
            if (this._octave - other._octave < -1) return 1;
            if (this._octave - other._octave > 1) return -1;
            if (this._octave == EOctave.SubContra)
            {
                return ComparingNotesOfSubContraOctave(other);
            }
            if (other._octave == EOctave.Fifth)
            {
                return ComparingNoteOfFifthOctave(other);
            }            
            // when two NEIGHBOUR octave NOTES (B and C) are compared
            if (this._octave - other._octave == -1 || this._octave - other._octave == 1)
            {
                return ComparingTwoNotesFromNeighbourOctaves(other);
            }
            else
            {
                if ((this._note - other._note) == -2 || (this._note - other._note) == 2)
                {
                    return ComparingTwoNotesWithBlackKeyBetweenThem(other);
                }
                if((this._note - other._note) == -1 || (this._note - other._note) == 1 )
                {
                    return ComparingTwoNotes(other);
                }
                if ((this._note - other._note) == 0)
                {  
                    return ComparingTwoSameNotes(other);
                }                
                //           D  follows    F
                if ((this._note - other._note) < -1) return 1;
                // F precedes  D
                return -1;
            }
        }
        private readonly int ComparingNoteOfFifthOctave(Key other)
        {
            if (other._octave == EOctave.Fifth)
            {
                if (other._note == ENote.C)
                {
                    if (other._accidental == EAccidental.Sharp)
                    {
                        Console.WriteLine("C8 is 88th Key, it cannot have Sharp Note");
                    }
                    if (this._accidental - other._accidental == 1) return 0;
                }
                else Console.WriteLine("Cannot compare non existing Key");
            }
            return 1;
        }
        private readonly int ComparingNotesOfSubContraOctave(Key other)
        {
            if (this._octave == EOctave.SubContra)
            {
                if (this._note == ENote.A && other._note == ENote.B)
                {
                    //           A   follows   B
                    if ((this._note - other._note) == -2)
                    {
                        if (this._accidental - other._accidental == 1 ||
                            this._accidental - other._accidental == -1 ||
                            this._accidental - other._accidental == -2) return 1;
                        // when its the same key!    
                        if (this._accidental - other._accidental == 2) return 0;
                    }
                    //          B   precedes   A while comparing only!!! in Program.cs
                    if ((this._note - other._note) == 2)
                    {
                        // when this.Note always precedes(KEY is on the RIGHT) the other.Note  
                        if (this._accidental - other._accidental == 0 ||
                            this._accidental - other._accidental == -1 ||
                            this._accidental - other._accidental == 1 ||
                            this._accidental - other._accidental == 2) return -1;
                        // when its the same key!    
                        if (this._accidental - other._accidental == -2) return 0;

                    }
                }
                else Console.WriteLine("Cannot compare non existing Key");
            }
            return -1;
        }
        private readonly int ComparingTwoNotesFromNeighbourOctaves(Key other)
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
        private readonly int ComparingTwoNotesWithBlackKeyBetweenThem(Key other)
        {
            //           C   follows   D
            if ((this._note - other._note) == -2)
            {
                if (this._accidental - other._accidental == 1 ||
                    this._accidental - other._accidental == -1 ||
                    this._accidental - other._accidental == -2) return 1;
                // when its the same key!    
                if (this._accidental - other._accidental == 2) return 0;
            }
            //          D   precedes   C while comparing only!!! in Program.cs
            if ((this._note - other._note) == 2)
            {
                // when this.Note always precedes(KEY is on the RIGHT) the other.Note  
                if (this._accidental - other._accidental == 0 ||
                    this._accidental - other._accidental == -1 ||
                    this._accidental - other._accidental == 1 ||
                    this._accidental - other._accidental == 2) return -1;
                // when its the same key!    
                if (this._accidental - other._accidental == -2) return 0;

            }
            return -1;
        }
        private readonly int ComparingTwoNotes(Key other)
        {
            //          E    follows   F
            if ((this._note - other._note) == -1)
            {
                if (this._accidental - other._accidental == -2 ||
                    this._accidental - other._accidental == -1 ||
                    this._accidental - other._accidental == 0) return 1;
                // when its the same key!
                if (this._accidental - other._accidental == 1) return 0;
                //when this.Note always precedes(KEY is on the RIGHT) the other.Note
                if (this._accidental - other._accidental == 2) return -1;
            }
            //          F   precedes   E while comparing only!!! in Program.cs
            if ((this._note - other._note) == 1)
            {
                if (this._accidental - other._accidental == -2 ||
                    this._accidental - other._accidental == 0) return 1;
                if (this._accidental - other._accidental == -1) return 0;
                if (this._accidental - other._accidental == 1) return -1;

            }
            return -1;
        }
        private readonly int ComparingTwoSameNotes(Key other)
        {
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
            return 0;
        }
        public override bool Equals(object obj)
        {
            return this.CompareTo((Key)obj) == 0;
        }
    }
}
