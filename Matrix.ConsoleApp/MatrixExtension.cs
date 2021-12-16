using System;
using System.Linq;

namespace Matrix.ConsoleApp
{
    internal static class MatrixExtension 
    {
        public static Matrix GetNewMatrixFromAddingTwoMatrices(this Matrix first, Matrix second)
        {
            //adding elements of two arrays
            int[] array = new int[first.Size];
            if (first.Size > second.Size)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = first[i, i] + second[i, i];
                }
            }
            //every other array size is ok
            else
            {
                array = new int[second.Size];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = first[i, i] + second[i, i];
                }
            }
            return new Matrix(array);
        }
    }
}
