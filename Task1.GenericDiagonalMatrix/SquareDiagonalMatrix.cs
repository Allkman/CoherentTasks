using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.GenericDiagonalMatrix
{
    internal class SquareDiagonalMatrix<T>
    {
        private T[] _diagonalMatrixArray;
        //2.
        public int Size => _size;
        readonly int _size;
        public T? this[int i, int j]
        {
            get
            {
                if (i < 0 && j < 0 || i >= _size && j >= _size || i != j)
                {
                    return default(T);
                }
                else if (i == j)
                {
                    return _diagonalMatrixArray[i];
                }
                else return default(T);
            }
            set
            {
                if (i >= 0 && j >= 0 || i <= _size && j <= _size || i == j)
                {
                    _diagonalMatrixArray[i] = value;
                }

            }
        }
        public SquareDiagonalMatrix(params T[] squareDiagonalMatrix)
        {

        }
    }
}
