using Task1.SparseNumericMatrix.Entities;

var claass = new Class1();
var sparseMatrix = new SparseMatrix(3, 3);
sparseMatrix[0,2] = 33;
sparseMatrix[1,2] = 44;

Console.WriteLine(sparseMatrix.ToString());
var nonZeroElements = sparseMatrix.GetNoZeroElements();
foreach (var item in nonZeroElements)
{
    Console.WriteLine(item);
}
