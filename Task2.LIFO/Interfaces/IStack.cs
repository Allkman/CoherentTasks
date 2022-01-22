using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LIFO.Interfaces
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        bool IsEmpty();
        T Peek();
    }
}
