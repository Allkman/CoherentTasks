using System.Text;

namespace Task1.GenericDiagonalMatrix
{
    //Followed docs.ms Guidlines @
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
    internal class SquareDiagonalMatrix<T>
    {
        public T?[] MatrixArray;
        public int Size => _size;
        readonly int _size;

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
                    return MatrixArray[i];
                }
                else return default(T);
            }
            set
            {
                if (i >= 0 && j >= 0 || i <= _size && j <= _size || i == j)
                {
                    MatrixArray[i] = value;
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
                MatrixArray = new T[_size];
                Array.Copy(squareDiagonalMatrix, MatrixArray, _size);
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
        // Wrap event invocations inside a protected virtual method
        // to allow derived classes to override the event invocation behavior
        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            for (int i = 0; i < _size; i++)
            {
                if (!Equals(e.OldValue, e.NewValue))
                {
                    // Call to invoke the event.
                    ElementChanged?.Invoke(this, e);
                }
            }
        }
    }
}
