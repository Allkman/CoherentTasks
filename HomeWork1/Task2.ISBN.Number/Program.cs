using System;

namespace Task2.ISBN.Number
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine();

            Console.WriteLine("Thank you.");
            Console.ReadKey();
        }
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

            return $"{isbn}-{checkDigit}";
        }
    }
}