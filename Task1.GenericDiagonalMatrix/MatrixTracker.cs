using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.GenericDiagonalMatrix
{
    internal class MatrixTracker<T>
    {
        public MatrixTracker(SquareDiagonalMatrix<T> squareDiagonalMatrix)
        {
           squareDiagonalMatrix.ElementChanged +=(sender, eventArgs) => Undo(sender, eventArgs);
        }

        public void Undo(object? sender, ElementChangedEventArgs<T> e)
        {
            if (sender is SquareDiagonalMatrix<T>)
            {
                e.NewValue = e.OldValue;
            }
        }
    }
}