namespace Task1.GenericDiagonalMatrix
{
    internal class MatrixTracker<T>
    {
        public MatrixTracker(SquareDiagonalMatrix<T> squareDiagonalMatrix)
        {
            squareDiagonalMatrix.ElementChanged += Undo;

        }
        public void Undo(object? sender, ElementChangedEventArgs<T> e)
        {
            if (sender != null)
            {
                // TODO implement logic for Undo();
            }
        }
    }
}
