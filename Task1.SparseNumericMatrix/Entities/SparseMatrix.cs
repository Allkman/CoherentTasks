using System.Collections;
using System.Text;

namespace Task1.SparseNumericMatrix.Entities
{
    internal class SparseMatrix : IEnumerable<int> 
    {
        private struct Key
        {
            public int RowIndex { get; set; }
            public int ColumnIndex { get; set; }
            public Key(int rowIndex, int columnIndex)
            {
                RowIndex = rowIndex;
                ColumnIndex = columnIndex;
            }
        }
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        private Dictionary<Key, int> _cells = new Dictionary<Key, int>();
        public int this[int i, int j]
        {
            get
            {
                var key = new Key(i, j);
                int value;
                return _cells.TryGetValue(key, out value) ? value : default;
            }
            set
            {
                var key = new Key(i, j);
                if (value != 0)
                {
                    _cells[key] = value;
                }
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
            //just check element and if it is not zero, add it to the list
            List<(int, int, int)> tupleList = new List<(int, int, int)>();

            foreach (var cell in _cells)
            {
                tupleList.Add((cell.Key.RowIndex, cell.Key.ColumnIndex, cell.Value));
            }
            return tupleList.OrderBy(x => x.Item2).ThenBy(y => y.Item1);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    yield return this[i, j];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int GetCount(int x)
        {
            int count = 0;
            foreach (var item in this)
            {
                if (x == item)
                {
                    count++;
                }
            }
            return count; 
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            if (RowCount == 0 || ColumnCount == 0)
            {
                return string.Empty;
            }
            for (int i = 0; i < RowCount; i++)
            {
                sb.AppendLine();
                for (int j = 0; j < ColumnCount; j++)
                {
                    sb.Append(this[i, j]);
                }
            }
            return sb.ToString();
        }
    }
}
