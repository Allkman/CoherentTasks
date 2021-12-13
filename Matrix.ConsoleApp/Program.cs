using System;

namespace Matrix.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixArray2 = new int[] { 8, 2, 3, 3, 4 };
            var matrixArray1 = new int[] { 3, 3, 4 };

            Console.WriteLine("[------------------]");
            Console.WriteLine("The diagonal vector of the matrix 1");
            foreach (var item in matrixArray1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine("The diagonal vector of the matrix 2");
            foreach (var item in matrixArray2)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine("[------------------]");
            Console.WriteLine();
            Console.WriteLine("Matrix 1:");
            var matrix1 = new Matrix(matrixArray1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The sum of diagonal: {matrix1.Track()}");           

            Console.WriteLine();
            Console.WriteLine("Matrix 2:");
            var matrix2 = new Matrix(matrixArray2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The sum of diagonal: {matrix2.Track()}");
            Console.WriteLine();
            Console.WriteLine($"Two matrixes are equal: {matrix1.Equals(matrix2)}");
            Console.WriteLine();
            Console.WriteLine("The result of the addition of two above matrices:");
            matrix1.GetNewMatrixFromAddingTwoMatrices(matrix2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And the result if I switch Matrix1 with Matrix2");
            matrix2.GetNewMatrixFromAddingTwoMatrices(matrix1);
            Console.WriteLine();
            Console.ReadLine();
        }
    }    
}
