// See https://aka.ms/new-console-template for more information
using Task1.PianoKeyboard.Entities;
using Task1.PianoKeyboard.Enums;

var C = new Key(ENote.E, EAccidental.Sharp, EOctave.First);
var D = new Key(ENote.F, EAccidental.NoSign, EOctave.First);
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(c.CompareTo(d));
C.ToString();
D.ToString();
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(C.CompareTo(D));

Console.WriteLine(C.Equals(D));

