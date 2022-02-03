namespace Task1.GenericDiagonalMatrix
{
    internal static class GenericMatrixExtension
    {
        public static DiagonalMatrix<T> Add<T>(
            this DiagonalMatrix<T> first,
            DiagonalMatrix<T> second,
            Func<T?, T?, T> additionOfT)
        {
            var newArrayLength = 0;
            if (first.Size > second.Size || first.Size == second.Size)
            {
                newArrayLength = first.Size;
            }
            else if (second.Size > first.Size)
            {
                newArrayLength = second.Size;
            }
            var tempMatrix = new DiagonalMatrix<T>(newArrayLength);
            for (int i = 0; i < newArrayLength; i++)
            {
                if (i < 0 || i >= newArrayLength)
                {
                    throw new IndexOutOfRangeException();
                }
                tempMatrix[i,i] = additionOfT.Invoke(first[i,i], second[i,i]);
            }
            return tempMatrix;
        }        
    }
}
