using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.LIFO.Interfaces;

namespace Task2.LIFO
{
    internal class Stack<T> : IStack<T> 
    {
        private T[] _stack;
        private int _lastItemIndex = -1; // top
        private readonly int _maxSize;
        //setting Count to 0 (zero)
        public int Count { get => _lastItemIndex + 1; }
        public Stack(int maxSize)
        {
           _maxSize = maxSize;            
            _stack = new T[maxSize];
        }
        public bool IsEmpty()
        {
            return _lastItemIndex < 0;
        }
        public T Pop()
        {
            T item;
            if (Count > 0)
            {
            item = _stack[_lastItemIndex];
            _lastItemIndex--;

            }
           else
                throw new InvalidOperationException("Sequence contains no elements");

            return item;
        }

        public void Push(T item)
        {
            if ((_lastItemIndex + 1) == _maxSize)
            {
                throw new StackOverflowException();
            }
            _lastItemIndex++;
            _stack[_lastItemIndex] = item;
        }

        public T Peek()
        {
            return _stack[_lastItemIndex];
        }
    }
}
