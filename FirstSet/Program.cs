using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FirstSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[------ Task =[ 1 ]= ------]");
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

            Console.WriteLine("[--------------------------]");
            Console.WriteLine();

            Console.WriteLine("[------ Task =[ 2 ]= ------]");
            ///summary of Task 2.
            ///The 10-digit ISBN is a numeric code that uniquely identifies a book. It has the
            ///following form: d1d2d3d4d5d6d7d8d9d10..Digit d10 is a control one.It is calculated
            ///according to the condition that the expression 10d1 + 9d2 + 8d3 + .. .+1d10
            ///(the sum of the products of code elements by the weight of their positions) must be a
            ///multiple of 11.Create a program that prompts the user for a 9 character - digit string(the
            ///first nine digits of the ISBN), calculates the check digit, and prints the resulting ISBN.Do
            ///not check the correctness of the user's input - assume that the user does not make
            ///mistakes when entering.
            ///Note 1: the check "digit" can be equal to 10.In this case, the symbol X is used to denote it.
            ///
            Console.WriteLine("Input the first nine digits of ISBN number");
            var nineDigitNumber = Console.ReadLine();
            //043942089 - this is as an example to get Check Digit = 10 so it will convert to X
            //019852663 6
            Console.WriteLine(ReturnISBN(nineDigitNumber));

            Console.WriteLine("[--------------------------]");
            Console.WriteLine();

            Console.WriteLine("[------ Task =[ 3 ]= ------]");
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
            Console.WriteLine("[--------------------------]");
            Console.WriteLine();

            Console.WriteLine("Thank you.");
            Console.ReadKey();
        }
        #region Task 3
        private static void PrintSumOfNumbers()
        {
            var intArray = ReturnNumbers();
            //examples
            //#1
            //var intArray = new List<int> { 1, 1, 2, 7, 7, 5, 6 }; 
            //output: 1, 1, 2, 7, 7 (smallest left-most is 1 at[0] and largest right-most is 7 at[4]
            //#2
            //var intArray = new List<int> { 6, 5, 7, 7, 2, 1, 1 }; 
            //output: 7, 2, 1 (this condition is not written in an assignment)
            var min = intArray.Min();
            var minIndex = intArray.FindIndex(i => i == min);
            var max = intArray.Max();
            var maxIndex = intArray.FindLastIndex(i => i == max);
            var sum = 0;

            Console.WriteLine("The new list with min ... max values: ");
            for (int i = 0; i < intArray.Count; i++)
            {
                //iterating through the list and adding values that are in the range of min/max (inclusive)
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
        #endregion
        #region Task 2
        private static int ReturnSumOfNineDigits(string isbn)
        {
            int sumOfNineDigits = 0;
            int inputLength = 9;
            int multiplier = 10;
            //bellow loop is: ((10*d1)+(9*d2)+(8*d3)+(7*d4)+(6*d5)+(5*d6)+(4*d7)+(3*d8)+(2*d9))
            for (int i = 0; i < inputLength; i++)
            {
                sumOfNineDigits += (isbn[i] - '0') * (multiplier - i);
            }
            //043942089 X
            //019852663 6            
            return sumOfNineDigits;
        }
        private static string ReturnISBN(string isbn)
        {
            int sumOfNineDigits = ReturnSumOfNineDigits(isbn);
            int remainder = sumOfNineDigits % 11;

            string checkDigit = (11 - remainder).ToString();
            //if remainder is 1 then the check digit is 10, so i set new value to X
            if (checkDigit == "10")
            {
                checkDigit = "X";
            }

            var sb = new StringBuilder();
            sb.Append(isbn);
            sb.Append(checkDigit);
            return $"{isbn}-{checkDigit}";
        }
        #endregion
        #region Task 1
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
        #endregion
    }
}
