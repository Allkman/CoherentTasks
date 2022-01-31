using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SparseNumericMatrix.Entities
{
    //https://docs.microsoft.com/en-us/dotnet/standard/collections/thread-safe/
    internal class SparseMatrix : IEnumerable<int> 
    {
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        //putting cells into a dictionary https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2?view=net-6.0
        private ConcurrentDictionary<Tuple<int, int>, int> _cells = new ConcurrentDictionary<Tuple<int, int>, int>();
        public int this[int row, int column]
        {
            get
            {
                var key = new Tuple<int, int>(row, column);
                int value;
                _cells.TryGetValue(key, out value);
                return value;
            }
            set
            {
                var key = new Tuple<int, int>(row, column);
                if (value == 0)
                {
                    _cells.TryRemove(key, out value);
                }
                _cells[key] = value;
            }
        }
        public SparseMatrix(int row, int column, int indexer)
        {
            if (row > 0 && column > 0)
            {
            RowCount = row;
            ColumnCount = column;

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public IEnumerable<(int, int, int)> GetNoZeroElements(int col, int row, int value)
        {
  
            return _cells.Where(x => x.Key.Item1 == col, x.Key.Item2 == row, x.Value == value);

        }

        public int GetCount(int x)
        {
            x = _cells.Count;
            return x; 
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

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _cells)
            {
               
                item.Key.
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
