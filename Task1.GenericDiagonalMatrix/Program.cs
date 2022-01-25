﻿using Task1.GenericDiagonalMatrix;


int[] firstArray = new int[] { 4, 6, 7 };
int[] secondArray = new int[] { 2, 1, 2 };
Console.WriteLine("firstArray:");
foreach (var item in firstArray)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();
Console.WriteLine("secondArray:");
foreach (var item in secondArray)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();
var topIndex = firstArray.Length-1; // last index
var oldValue = firstArray[topIndex];
var newValue = firstArray[topIndex] = 99;
var intEventArgs = new ElementChangedEventArgs<int>(topIndex, oldValue, newValue);

Console.WriteLine("Changing the element of firstArray:");
foreach (var item in firstArray)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();
Console.WriteLine("Undoing the changes:");
var firstMatrix = new SquareDiagonalMatrix<int>(firstArray);
var firstMatrixTracker = new MatrixTracker<int>(firstMatrix);

//TODO call correct Undo(); impelementation...

//firstMatrixTracker.Undo(firstMatrix, intEventArgs);
Console.WriteLine();
//Console.WriteLine("Printing Diagonal Square Matrix");
//Console.WriteLine(firstMatrix.ToString());

var secondMatrix = new SquareDiagonalMatrix<int>(secondArray);

Console.WriteLine(secondMatrix.ToString());
static int AdditionOfT(int first, int second)
{
    var d1 = Convert.ToDouble(first);
    var d2 = Convert.ToDouble(second);
    return (int)(dynamic)(d1 + d2);
}
Console.WriteLine("The result of adding two matrices: (without Undo() implementation");
var combinedMatrix = GenericMatrixExtension.Add(firstMatrix, secondMatrix, AdditionOfT);
Console.WriteLine(combinedMatrix.ToString());

Console.ReadLine();
