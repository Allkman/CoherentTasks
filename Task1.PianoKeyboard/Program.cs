// See https://aka.ms/new-console-template for more information
using Task1.PianoKeyboard.Entities;
using Task1.PianoKeyboard.Enums;

//var C = new Key(ENote.B, EAccidental.NoSign, EOctave.Fourth);
//var D = new Key(ENote.C, EAccidental.Flat, EOctave.Fifth);

//C.ToString();
//D.ToString();
//Console.WriteLine(C);
//Console.WriteLine(D);
//Console.WriteLine(C.CompareTo(D));

//Console.WriteLine(C.Equals(D));
//Refactoring
var C_Sharp = new Key(ENote.B, EAccidental.NoSign, EOctave.Second);
var D_Flat = new Key(ENote.C, EAccidental.Flat, EOctave.Third);

C_Sharp.ToString();
D_Flat.ToString();
Console.WriteLine(C_Sharp);
Console.WriteLine(D_Flat);
Console.WriteLine(C_Sharp.CompareTo(D_Flat));

Console.WriteLine(C_Sharp.Equals(D_Flat));