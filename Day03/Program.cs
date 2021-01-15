using System;

namespace Day03
{
    class Program
    {
        public static void Main(string[] args)
        {
            //// break
            //for (int i = 0; i < 99999999; i++)
            //{
            //    Console.WriteLine(i);
            //    break;
            //}

            //while (true)
            //{
            //    Console.WriteLine("HI");
            //    break;
            //}

            //// continue
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}

            //// Nesting loops, scope, and break
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"i is {i}");
            //    for (int j = 0; j < 10; j++)
            //    { 
            //        Console.WriteLine($"i is {i} and j is {j}");
            //        break;
            //    }
            //}

            //// While with a break.  Is it good?  Is it bad? It depends who you ask.
            //while (true)
            //{
            //    Console.WriteLine("Enter y or n:");
            //    string response = Console.ReadLine();
            //    if (response == "y")
            //    {
            //        break;
            //    }
            //}

            //// Exercise 6 
            //string response;
            //do
            //{
            //    Console.WriteLine("Hello World!"); 
            //    Console.WriteLine("Would you like to continue (y/n)?");
            //    response = Console.ReadLine();
            //    if (response != "y" && response != "n")
            //    {
            //        Console.WriteLine("OOPS! You need to enter 'y' or 'n'!");
            //        response = "y";
            //    }
            //} while (response == "y");

            //Console.WriteLine("Goodbye!");

            //// Exercise 6 -- alternate
            //string response;
            //do
            //{
            //    Console.WriteLine("Hello World!");
            //    bool isInvalid;
            //    do
            //    {
            //        Console.WriteLine("Would you like to continue (y/n)?");
            //        response = Console.ReadLine();
            //        isInvalid = response != "y" && response != "n";
            //        if (isInvalid)
            //        {
            //            Console.WriteLine("OOPS! You need to enter 'y' or 'n'!");
            //        }
            //    } while (isInvalid);
            //} while (response == "y");

            //Console.WriteLine("Goodbye!");

            //// The var keyword automatically give a variable a type based on how you intialize it.
            //var myNumber = 3;
            //var myName = "Jason";
            //var myArr = new int[] {5};

            //int numberTwo; // Declaring
            //numberTwo = 2; // Initializing

            //int numberThree = 3; // Declaring and intializing in one line
            //var numberFour = 4; // On one line you can use var which is preferred.

            // Parsing strings
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            var inputNumber = double.Parse(input);
            Console.WriteLine(inputNumber * 2);
        }
    }
}
