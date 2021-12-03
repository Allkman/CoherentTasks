using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1.NumberListWith2TwosInTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            ///summary of Task 1.
            ///Create a console application, which asks the user for two integers a and b (assume
            ///that the user enters integers without errors). The application then prints out all integers
            ///in the range from a (inclusive)to b(inclusive) that have exactly two 2's in their ternary
            ///number system(0, 1, 2) representation.Develop a console application that implements
            ///the specified functionality.
            ///Note: to convert a string s to an int value, use the int.Parse(s) method.
            ///
            Console.WriteLine("Input the first number:");
            var inputA = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number:");
            var inputB = int.Parse(Console.ReadLine());

            DisplayNumbersThatHave2TwosInTernary(inputA, inputB);
            Console.WriteLine();

            Console.WriteLine("Thank you.");
            Console.ReadKey();
        }
     
        private static void DisplayNumbersThatHave2TwosInTernary(int inputA, int inputB)
        {
            var inputRange = new List<int>();
            //using LINQ to add written inputs range into a list
            inputRange.AddRange(Enumerable.Range(inputA, (inputB - inputA + 1)));
            Console.WriteLine($"The list of numbers from {inputA} to {inputB} that has two '2' in their ternary number: ");
            foreach (var item in inputRange)
            {
                var ternaryString = ReturnTernaryNumber(item).ToString();
                var twoTwice = Regex.Matches(ternaryString, "2").Count;
                if (twoTwice == 2)
                {
                    Console.Write($"{item}, ");
                }
            }
            Console.WriteLine();
        }
        private static StringBuilder ReturnTernaryNumber(int numb)
        {
            var ternaryNumber = new StringBuilder();
            //if i input 0, i need not to run the rest of the code, because convertion from 0 is always 0
            if (numb == 0)
            {
                return ternaryNumber.Append(0);
            }
            var remainders = new List<int>();
            //I neen to run while until the value of numb  is 0, no remainders left to add.
            while (numb >= 1)
            {
                remainders.Add(numb % 3);
                numb /= 3;
            }
            //I need to reverse the list of ramainders, because the division by 3 puts first remainder on the left.
            remainders.Reverse();

            foreach (var remainder in remainders)
            {
                ternaryNumber.Append(remainder);
            }

            return ternaryNumber;
        }
    }
}
