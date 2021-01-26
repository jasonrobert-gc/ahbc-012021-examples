using System;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = GetNumberWithException();
                Console.WriteLine($"Your number x2 is {number * 2}");
                Console.WriteLine("Thanks for playing");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Something unexpected happened! - {ex.Message}");
                Console.ResetColor();
            }
        }

        private static int GetNumberSafelyDoLoop()
        {
            int result;
            bool isValid;
            do
            {
                Console.Write("Pick a number: ");
                string response = Console.ReadLine();
                isValid = int.TryParse(response, out result);
            } while (!isValid);

            return result;
        }

        private static int GetNumberSafelyWhileLoop()
        {
            int result;
            Console.Write("Pick a number: ");
            string response = Console.ReadLine();
            while (!int.TryParse(response, out result))
            {
                Console.Write("I said a NUMBER! Pick a number: ");
                response = Console.ReadLine();
            }

            return result;
        }

        private static int GetNumberWithException()
        {
            try
            {
                var response = Console.ReadLine();
                int result = int.Parse(response);
                return result;
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"OH NO! An error occurred! - {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Something unexpected happened! - {ex.Message}");
                Console.ResetColor();
            }

            return 0;
        }

        private static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArithmeticException("You cannot divide by zero!");
            }

            return num1 / num2;
        }
    }
}
