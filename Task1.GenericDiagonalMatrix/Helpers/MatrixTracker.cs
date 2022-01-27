namespace Task1.GenericDiagonalMatrix
{
    internal class MatrixTracker<T>
    {
        private DiagonalMatrix<T> _matrix;
        public MatrixTracker(DiagonalMatrix<T> squareDiagonalMatrix)
        {
            _matrix = squareDiagonalMatrix;
            squareDiagonalMatrix.ElementChanged += Undo;

        }
        public void Undo(object? sender, ElementChangedEventArgs<T> e)
        {
            if (sender != null)
            {
                _matrix.ElementChanged -= Undo;
                _matrix[e.Index, e.Index] = e.OldValue;
            }
        }
    }
}
