using System;
using System.Text.RegularExpressions;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            //var escapeCharacters = "Here is a tab \t Here is an LF \n...";
            //Console.WriteLine(escapeCharacters);

            SayHelloKindly("Jason");

            Console.Write("Email: ");
            var email = Console.ReadLine();

            if (IsEmailAddress(email))
            {
                Console.WriteLine("It matches!");
            }
            else
            {
                Console.WriteLine("It does not match! :(");
            }

            var sum1 = Sum(5, 5, 5);

            //IsEmailAddress();
            //IsEmailAddress(23);
            //Sum("1", "4");
        }

        private static bool IsEmailAddress(string email2)
        {
            //// three lines
            //var regex = @"^\s*[\w-_\.]+@([\w-]+\.)+[\w-]{2,4}\s*$";
            //var result = Regex.IsMatch(email, regex);
            //return result;

            //// two lines
            //var regex = @"^\s*[\w-_\.]+@([\w-]+\.)+[\w-]{2,4}\s*$";
            //return Regex.IsMatch(email, regex);

            // one line
            return Regex.IsMatch(email2, @"^\s*[\w-_\.]+@([\w-]+\.)+[\w-]{2,4}\s*$");

            // Which is better?  You decide!
        }

        private static void SayHelloKindly(string person)
        {
            Console.WriteLine($"Hello {person} my good sire!");
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method OOOOOOOOOverloading
        private static int Sum(int num1, int num2, int num3)
        {
            return Sum(num1, num2) + num3;
        }
    }
}
