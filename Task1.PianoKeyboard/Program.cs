using Task1.PianoKeyboard.Entities;
using Task1.PianoKeyboard.Enums;

var C_Sharp = new Key(Note.C, Accidental.Sharp, Octave.First);
var D_Flat = new Key(Note.D, Accidental.Flat, Octave.First);

C_Sharp.ToString();
D_Flat.ToString();
Console.WriteLine(C_Sharp);
Console.WriteLine(D_Flat);
Console.WriteLine(C_Sharp.CompareTo(D_Flat));

Console.WriteLine(C_Sharp.Equals(D_Flat));