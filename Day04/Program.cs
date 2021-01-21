using System;
using System.Text;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            //String someString;
            //string someStringCorrect;

            //Int32 someNumber;
            //int someNumberCorrect;

            // Concatenating strings

            string myString1 = "Hello World";
            myString1 += ", Jason";
            string myString2 = myString1;
            myString1 = myString1 + " Robert";

            // Comparing Strings

            var mystring3 = "jason";
            var mystring4 = "Jason";
            Console.WriteLine(mystring3 == mystring4); // Case sensitive
            Console.WriteLine(mystring3.Equals(mystring4, StringComparison.OrdinalIgnoreCase)); // Case insensitive

            // Common string instance methods

            Console.WriteLine($"Length - {mystring3.Length}");
            Console.WriteLine($"Substring - {mystring3.Substring(2)}");
            Console.WriteLine($"Contains - {mystring3.Contains("son")}");
            Console.WriteLine($"ToUpper - {mystring3.ToUpper()}");

            // Common string class methods

            Console.WriteLine($"Empty - {string.Empty}");
            Console.WriteLine($"IsNullOrEmpty - {string.IsNullOrEmpty(mystring4)}");

            // Using string builder

            var sb = new StringBuilder();
            sb.Append("Hello World");
            sb.Append(", Jason");
            sb.Append(" Robert");
            Console.WriteLine(sb.ToString());
        }
    }
}
