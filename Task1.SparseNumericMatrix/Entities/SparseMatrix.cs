using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.SparseNumericMatrix.Entities
{
    internal class SparseMatrix : IEnumerable<int> 
    {
        
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        private Dictionary<int, int> _cells = new Dictionary<int, int>();
        public int this[int i, int j]
        {
            get
            {
                var key = i * ColumnCount + j;
                int value;
                _cells.TryGetValue(key, out value);
                return value;
            }
            set
            {
                var key = i * ColumnCount + j;
                //to save memory i remove all zero values
                //if (value == 0)
                //{
                //    _cells.Remove(key, out value);
                //}
                _cells[key] = value;
            }
        }
        public SparseMatrix(int row, int column)
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
        public IEnumerable<(int, int, int)> GetNoZeroElements()
        {
            //var cell = _cells.Keys.GetEnumerator();
            //while (cell.MoveNext())
            //    yield return (cell.Current, cell.Current, cell.Current);

            _cells.GetEnumerator();

            return _cells.Select(x => (x.Key, x.Key, x.Value)).ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _cells)
            {
                yield return _cells.Select(x => x.Key).First();
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public int GetCount(int x)
        {
            return x; 
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            if (RowCount == 0 || ColumnCount == 0)
            {
                return string.Empty;
            }
            for (int row = 0; row < RowCount; row++)
            {
                sb.AppendLine();
                for (int column = 0; column < ColumnCount; column++)
                {
                    sb.Append(this[row, column]);
                }
            }
            return sb.ToString();
        }
    }
}
