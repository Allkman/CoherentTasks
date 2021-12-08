using System;

namespace Matrix.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixArray1 = new int[] { 4, 3, 6, 1, 5 };
            var matrixArray2 = new int[] { 8, 2, 7 };
            var matrix1 = new Matrix(matrixArray1);
            Console.WriteLine();
            var matrix2 = new Matrix(matrixArray2);
        }
    }
}
