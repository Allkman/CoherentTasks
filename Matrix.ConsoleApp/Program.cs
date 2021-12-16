using System;

namespace Matrix.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixArray1 = new int[] { 3, 3, 4};
            var matrixArray2 = new int[] { 0, 0, 5, 5 };

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
            Console.WriteLine("Track() method");
            Console.WriteLine($"The sum of diagonal: {matrix1.Track()}");
            Console.WriteLine("ToString() method");
            Console.WriteLine(matrix1.ToString()); 
            Console.WriteLine();
            Console.WriteLine("Matrix 2:");
            var matrix2 = new Matrix(matrixArray2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Track() method");
            Console.WriteLine($"The sum of diagonal: {matrix2.Track()}");
            Console.WriteLine("ToString() method");
            Console.WriteLine(matrix2.ToString());
            Console.WriteLine();
            Console.WriteLine($"Two matrixes are equal: {matrix1.Equals(matrix2)}");
            
            Console.WriteLine();
            Console.WriteLine("The result of the addition of two above matrices:");
            matrix1.GetNewMatrixFromAddingTwoMatrices(matrix2);

            Console.WriteLine();
            Console.ReadLine();
        }
    }    
}
