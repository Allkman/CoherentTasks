﻿namespace Task1.GenericDiagonalMatrix
{
    internal static class GenericMatrixExtension
    {
        public static DiagonalMatrix<T> Add<T>(
            this DiagonalMatrix<T> first,
            DiagonalMatrix<T> second,
            Func<T?, T?, T> AdditionOfT)
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
            T[] newArray = new T[newArrayLength];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = AdditionOfT.Invoke(first[i,i], second[i,i]);
            }
            return new DiagonalMatrix<T>(newArray);
        }

        
    }
}
