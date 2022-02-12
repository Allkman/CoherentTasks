using Task1.SparseNumericMatrix.Entities;
try
{
    var sparseMatrix = new SparseMatrix(10, 10);
    sparseMatrix[0, 5] = 3;
    sparseMatrix[0, 3] = 0; //not set
    sparseMatrix[0, 4] = 0; //not set
    sparseMatrix[0, 2] = 3;
    sparseMatrix[5, 2] = 7;
    sparseMatrix[1, 2] = 4;

    Console.WriteLine(sparseMatrix.ToString());
    var nonZeroElements = sparseMatrix.GetNoZeroElements();
    foreach (var item in nonZeroElements)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine(sparseMatrix.GetCount(3)); //2
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Matrix must consist of integer numbers starting from 1");
}