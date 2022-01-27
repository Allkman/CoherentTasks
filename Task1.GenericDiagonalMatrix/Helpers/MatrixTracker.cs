namespace Task1.GenericDiagonalMatrix
{
    internal class MatrixTracker<T>
    {
        private DiagonalMatrix<T> _matrix;
        //creating new ojb here to store its values that are coming from Event e
        private ElementChangedEventArgs<T> _eventArgs = new ElementChangedEventArgs<T>();

        public MatrixTracker(DiagonalMatrix<T> diagonalMatrix)
        {
            _matrix = diagonalMatrix;
            diagonalMatrix.ElementChanged += SquareDiagonalMatrix_ElementChanged;
        }
        private void SquareDiagonalMatrix_ElementChanged(object? sender, ElementChangedEventArgs<T> e)
        {
            _eventArgs = e;
        }
        public void Undo()
        {
            _matrix[_eventArgs.Index, _eventArgs.Index] = _eventArgs.OldValue;
        }
    }
}
