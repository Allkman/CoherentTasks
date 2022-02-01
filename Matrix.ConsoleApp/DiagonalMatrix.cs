using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Task 1. A diagonal matrix is a square matrix, all elements of which outside the main diagonal 
/// are equal to zero (read here Diagonal matrix - https://en.wikipedia.org/wiki/Diagonal_matrix).
/// You need to create and test a class to represent a diagonal matrix containing integers (int).
/// 1. The class object stores only the elements of the matrix located on the diagonal. For this, a one-dimensional array is used. 
/// 2.  The class object has a read-only property Size - the size of the matrix (for example, for a 5x5 matrix, the Size property returns 5).
/// 3. The class has a constructor for creating a matrix. A list of parameters (params) is passed to the constructor - these are the elements 
/// of the matrix located on the diagonal. If the value of the constructor argument is not correct (for example, equal to null),
/// a zero-size matrix is created (Size = 0). 
/// 4.  For convenience, the class offers an indexer with
/// two indices i and j. If i is not equal to j, then the indexer returns the value 0 (when writing, nothing happens).
/// If the values of the indices are not correct (out of bounds: less than zero or greater or equal to Size),
/// nothing happens during writing, and when reading, the value 0 is returned. (In this case an exception has to be generated,
/// but up to now this point wasn’t discussed). 5. The class of the matrix has an instance method Track (),
/// which returns the sum of the elements of the matrix located on the main diagonal. 
/// 6.  Override the Equals () and ToString () methods in the matrix class. Two matrices are considered equal
/// if their sizes and the corresponding elements on the diagonal coincide. 
/// 7.  Create a diagonal matrix extension method that adds two diagonal matrices. The result of the method is a new diagonal matrix.
/// If the dimensions of the matrix do not match, the smaller matrix is padded with zeros.
/// </summary>
/// <summary>
/// example of 3x3 diagonal matrix
/// [(i==j), (i!=j), (i!=j)] (X, 0, 0) is to index this 'X'
/// [(i!=j), (i==j), (i!=j)] (0, X, 0)
/// [(i!=j), (i!=j), (i==j)] (0, 0, X)
/// </summary>
namespace Matrix.ConsoleApp
{
    internal class DiagonalMatrix
    {
        private int[] _diagonalMatrixArray;
        public int Size => _size;
        private readonly int _size;
        public int this[int i, int j]
        {
            get
            {
                //If the index values are less than zero or greater than or equal to the size of the matrix, an IndexOutOfRangeException is thrown.
                if (i < 0 && j < 0 || i >= _size && j >= _size)
                {
                    throw new IndexOutOfRangeException();
                }
                //If i is not equal to j: when reading, the default value for type T is returned
                if(i != j) 
                {
                    return 0;
                }
                else if (i == j)
                {
                    return _diagonalMatrixArray[i];
                }
                else return 0;
            }
            set
            {
                if (i >= 0 && j >= 0 || i <= _size && j <= _size || i == j)
                {
                    _diagonalMatrixArray[i] = value;
                }
            }
        }
        public DiagonalMatrix(params int[] diagonalMatrixArray)
        {
            if ( diagonalMatrixArray.Length < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                _size = diagonalMatrixArray.Length;
                _diagonalMatrixArray = new int[_size];
                Array.Copy(diagonalMatrixArray, _diagonalMatrixArray, _size);
            }
        }
        public int Track()
        {
            return _diagonalMatrixArray.Sum();
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
        public override bool Equals(object obj)
        {
            //according to Jeffrey Richter (CLR via C#)
            var item = obj as DiagonalMatrix;
            // If  objects are different types,  they  can't be equal.  

            if (item == null)
            {
                return false;
            }
            //https://stackoverflow.com/questions/3232744/easiest-way-to-compare-arrays-in-c-sharp
            return Enumerable.SequenceEqual(this._diagonalMatrixArray, item._diagonalMatrixArray);
        }
    }
}