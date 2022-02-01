using Task1.GenericDiagonalMatrix;
static int AdditionOfT(int first, int second)
{
    return first + second;
}
try
{
    //firstMatrix
    var firstMatrix = new DiagonalMatrix<int>(3);
    firstMatrix[0, 0] = 1;
    firstMatrix[1, 1] = 4;
    firstMatrix[2, 2] = 1;
    Console.WriteLine(firstMatrix.ToString());
    Console.WriteLine();

    //Matrix Tracker
    var firstMatrixTracker = new MatrixTracker<int>(firstMatrix);
    firstMatrixTracker.Undo();
    Console.WriteLine(firstMatrix.ToString());

    //secondMatrix
    var secondMatrix = new DiagonalMatrix<int>(3);
    secondMatrix[0, 0] = 2;
    secondMatrix[1, 1] = 3;
    secondMatrix[2, 2] = 2;
    Console.WriteLine(secondMatrix.ToString());
    Console.WriteLine();

    //Matrix Extension
    Console.WriteLine("The result of adding two matrices:");
    Console.WriteLine(firstMatrix.Add(secondMatrix, AdditionOfT).ToString());
}
catch (ArgumentException)
{
    Console.WriteLine($"Matrix cannot be set to negative size.");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Matix index was out of bounds of an array.");
}

Console.ReadKey();
