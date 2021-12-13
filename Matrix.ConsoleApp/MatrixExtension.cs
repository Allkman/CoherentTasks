using System.Linq;

namespace Matrix.ConsoleApp
{
    internal static class  MatrixExtension //static because i dont need to create it
    {
        public static Matrix GetNewMatrixFromAddingTwoMatrices(this Matrix a, Matrix b)
        {
            int sizeOfNewMatrix = 0;
            var c = new int[sizeOfNewMatrix];//creating a new matrix = result of addition of two 

            if (a.Size != b.Size)
            {
                c = a.DiagonalMatrixArray.Concat(b.DiagonalMatrixArray).ToArray();
            }
                       
            return new Matrix(c);
        }
    }
}
