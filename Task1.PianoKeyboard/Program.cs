using Task1.PianoKeyboard.Entities;
using Task1.PianoKeyboard.Enums;

var C_Sharp = new Key(ENote.C, EAccidental.Sharp, EOctave.First);
var D_Flat = new Key(ENote.D, EAccidental.Flat, EOctave.First);

C_Sharp.ToString();
D_Flat.ToString();
Console.WriteLine(C_Sharp);
Console.WriteLine(D_Flat);
Console.WriteLine(C_Sharp.CompareTo(D_Flat));

Console.WriteLine(C_Sharp.Equals(D_Flat));