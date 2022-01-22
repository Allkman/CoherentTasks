using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.GenericDiagonalMatrix
{
    internal class SquareDiagonalMatrix<T>
    {
        private T?[] _squareDiagonalMatrix;
        public int Size => _size;
        readonly int _size;

        //public delegate void ElementChangedEventHandler(object sender, T oldValue, T newValue, int index);  
        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;
        public T? this[int i, int j]
        {
            get
            {
                if (i < 0 && j < 0 || i >= _size && j >= _size)
                {
                    throw new IndexOutOfRangeException();
                }
                if (i != j)
                {
                    return default(T);
                }
                else if (i == j)
                {
                    return _squareDiagonalMatrix[i];
                }
                else return default(T);
            }
            set
            {
                if (i >= 0 && j >= 0 || i <= _size && j <= _size || i == j)
                {
                    _squareDiagonalMatrix[i] = value;
                }

            }
        }
        public SquareDiagonalMatrix(params T[] squareDiagonalMatrix)
        {
            if (squareDiagonalMatrix.Length < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                _size = squareDiagonalMatrix.Length;
                _squareDiagonalMatrix = new T[_size];
                Array.Copy(squareDiagonalMatrix, _squareDiagonalMatrix, _size);
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Size == 0)
            {
                return string.Empty;
            }
            //a loop for creating a matrix, iterating through rows and columns:
            for (int row = 0; row < _size; row++)
            {
                sb.AppendLine();
                for (int column = 0; column < _size; column++)
                {
                    sb.Append(this[row, column]);
                }
            }
            return sb.ToString();
        }
        public virtual void OnElementChanged( ElementChangedEventArgs<T> e)
        {
            for (int i = 0; i < _size; i++)
            {
                if (!Equals(e.OldValue, e.NewValue))
                {
                    e.Index = i;
                    ElementChanged?.Invoke(this, e);
                    Console.WriteLine("Element has changed");
                }
            }
            
        }
    }
}
