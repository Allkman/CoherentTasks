using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.LIFO
{
    internal static class StackExtensions
    {
        public static Stack<T> Reverse<T>(this Stack<T> stack)
        {
            var reversedStack = new Stack<T>(stack.Count);

            while (stack.Count > 0) // or !stack.isEmpty()
            {
                reversedStack.Push(stack.Pop());
            }
            return reversedStack;
        }
    }
}
