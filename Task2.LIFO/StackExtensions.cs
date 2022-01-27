using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.LIFO.Interfaces;

namespace Task2.LIFO
{
    internal static class StackExtensions
    {
        public static IStack<T> Reverse<T>(IStack<T> stack)
        {
            IStack<T> reverseStack = new Stack<T>();

            while (!stack.IsEmpty())
            {
                reverseStack.Push(stack.Pop());
            }
            return reverseStack;
        }
    }
}
