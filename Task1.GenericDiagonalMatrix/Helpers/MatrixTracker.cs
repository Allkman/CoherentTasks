namespace Task1.GenericDiagonalMatrix
{
    internal class MatrixTracker<T>
    {
        DiagonalMatrix<T> matrix;
        public MatrixTracker(DiagonalMatrix<T> squareDiagonalMatrix)
        {
            matrix = squareDiagonalMatrix;
            squareDiagonalMatrix.ElementChanged += Undo;

        }
        public void Undo(object? sender, ElementChangedEventArgs<T> e)
        {
            if (sender != null)
            {
                matrix[e.Index, e.Index] = e.OldValue;
            }
        }
    }
}
