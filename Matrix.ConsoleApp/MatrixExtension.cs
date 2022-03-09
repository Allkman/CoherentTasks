using System;
using System.Linq;

namespace Matrix.ConsoleApp
{
    internal static class MatrixExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static DiagonalMatrix GetNewMatrixFromAddingTwoMatrices(this DiagonalMatrix first, DiagonalMatrix second)
        {
            var newArrayLength = 0;
            if (first.Size > second.Size || first.Size == second.Size)
            {
                newArrayLength = first.Size;
            }
            else if (second.Size > first.Size)
            {
                newArrayLength = second.Size;
            }
            int[] array = new int[newArrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = first[i, i] + second[i, i];
            }
            return new DiagonalMatrix(array);
        }
    }
}
