
using Task1.GenericDiagonalMatrix;

int[] intArray = new int[] { 4, 6, 7, 8, 1 };
foreach (var item in intArray)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();

var squareMatrix = new SquareDiagonalMatrix<int>(intArray);
var matrixTracker = new MatrixTracker<int>(squareMatrix);
var eventArgs = new ElementChangedEventArgs<int>();

Console.WriteLine("Changing the element:");
eventArgs.OldValue = intArray[0];
eventArgs.NewValue = intArray[0] = 99;
eventArgs.Index = 0;
foreach (var item in intArray)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();
Console.WriteLine("Undoing the changes:");
matrixTracker.Undo(squareMatrix, eventArgs);
Console.WriteLine();
Console.WriteLine("Printing Diagonal Square Matrix");
Console.WriteLine(squareMatrix.ToString());

//Console.WriteLine(squareMatrix);

   

