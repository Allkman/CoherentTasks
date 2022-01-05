using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LIFO.Interfaces
{
    public interface IStack<T>
    {
        T Push(T item);
        T Pop();
        T IsEmpty(T item);
    }
}
