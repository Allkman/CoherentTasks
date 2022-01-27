using System.Text;

namespace Task1.GenericDiagonalMatrix
{
    //Followed docs.ms Guidlines @
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
    internal class DiagonalMatrix<T>
    {
        public int Size => _size;
        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;
        private T?[] MatrixArray;
        private readonly int _size;
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
                    T? previousValue = MatrixArray[i];
                    MatrixArray[i] = value; //newValue
                    OnElementChanged(new ElementChangedEventArgs<T>(i, previousValue, value));
                }
            }
        }
        public DiagonalMatrix(int size)
        {
            _size = size >= 0 ? size : throw new ArgumentException();
            MatrixArray = new T[size];
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Size == 0)
            {
                return string.Empty;
            }
            for (int row = 0; row < MatrixArray.Length; row++)
            {
                sb.AppendLine();
                for (int column = 0; column < MatrixArray.Length; column++)
                {
                    sb.Append(this[row, column]);
                }
            }
            return sb.ToString();
        }
        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            for (int i = 0; i < MatrixArray.Length; i++)
            {
                if (!Equals(e.OldValue, e.NewValue))
                {
                    ElementChanged?.Invoke(this, e);
                }
            }
        }
    }
}
