using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.LIFO.Interfaces;

namespace Task2.LIFO
{
    public class Stack<T> : IStack<T>
    {
        private static int maxSize;
        private T[] array = new T[maxSize];
        private static int lastItem;
        public T IsEmpty(T item)
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public T Push(T item)
        {
            throw new NotImplementedException();
        }
    }
}
