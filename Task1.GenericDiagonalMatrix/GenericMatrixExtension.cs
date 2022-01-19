using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.GenericDiagonalMatrix
{
    //https://stackoverflow.com/questions/2292597/extension-method-for-generic-class/2292632
    internal static class GenericMatrixExtension
    {

        public static SquareDiagonalMatrix<T> Add<T>(
            this SquareDiagonalMatrix<T> first, 
            SquareDiagonalMatrix<T> second, 
            Func<T,T, SquareDiagonalMatrix<T>> AdditionOfT)
        {
            return;
        }
    }
}
