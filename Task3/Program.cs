using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3.SumOfListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            ///summary of Task 3. 
            ///The application asks the user for the number of elements in a numeric array (at
            ///least two), and then in a loop -the elements themselves(of int type). After entering the
            ///elements, the application prints out the original array and outputs the sum of the array
            ///elements located between the smallest element in the array(the leftmost element if there
            ///are several) and the largest element(the rightmost element if there are several). Develop
            ///a console application that implements the specified functionality.
            ///Example: array[1, 3, 5, 1, 0, 3, 0, 1].The sum of the required elements = 5 + 1 + 0 = 6.
            ///Note 1: the correctness of the length of the array can be left unchecked.
            ///Note 2: The smallest and largest items are to be included in the amount.
            ///
            PrintSumOfNumbers();
            Console.WriteLine();

            Console.WriteLine("Thank you.");
            Console.ReadKey();
        }
        private static void PrintSumOfNumbers()
        {
            var intArray = ReturnNumbers();
            //examples
            //#1
            //var intArray = new List<int> { 1, 1, 2, 10, 10, 5, 6 }; 
            //output: 1, 1, 2, 10, 10 (smallest left-most is 1 at[0] and largest right-most is 7 at[4]
            //#2
            //var intArray = new List<int> { 6, 5, 10, 10, 2, 1, 1 }; 
            //output: 10, 2, 1 (this condition is not written in an assignment)
            var min = intArray.Min();
            var minIndex = intArray.FindIndex(i => i == min);
            var max = intArray.Max();
            var maxIndex = intArray.FindLastIndex(i => i == max);
            var sum = 0;

            Console.WriteLine("The new list with min ... max values: ");
            for (int i = 0; i < intArray.Count; i++)
            {
                //iterating through the list and adding values that are in the range of min/max (inclusive,
                //but only for #1 condition as in the Task description)

                //this if is not required for this task, but it prints out Sum of array if max is earlier than min value (as in condition #2)
                if (i <= minIndex && i >= maxIndex)
                {
                    Console.Write($"{intArray[i]}, ");
                    sum += intArray[i];
                }
                else if (i >= minIndex && i <= maxIndex)
                {
                    Console.Write($"{intArray[i]}, ");
                    sum += intArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum between min and max is: {sum}");
            Console.WriteLine();
        }
        private static List<int> ReturnNumbers()
        {
            //Every time I run program I can set the count of a list
            Console.WriteLine("Input the size of the list: ");
            var intArray = new List<int>();
            var arrLength = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //creating random obj so that every time the program runs it will create
            //a different int from 0 to 25
            var rnd = new Random();
            for (int i = 0; i < arrLength; i++)
            {
                var number = rnd.Next(0, 25);
                intArray.Add(number);
            }
            foreach (var number in intArray)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine();
            return intArray;
        }
    }
}
