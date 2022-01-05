// See https://aka.ms/new-console-template for more information
using Task1.PianoKeyboard.Entities;
using Task1.PianoKeyboard.Enums;

var C = new Key(ENote.B, EAccidental.NoSign, EOctave.Fourth);
var D = new Key(ENote.C, EAccidental.Flat, EOctave.Fifth);

C.ToString();
D.ToString();
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(C.CompareTo(D));

Console.WriteLine(C.Equals(D));

