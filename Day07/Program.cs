using System;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Assessment Review
            //var first = "Kristy";
            //var last = "Currier";
            //var result = TryGetName(out first, out last);
            //Console.WriteLine($"{first} {last}");

            //PrintName(first, last);
            //Console.WriteLine($"{first} {last}");

            //var answer = IsTheSame(1, 2);

            //// Exercise 19
            //do
            //{
            //    var num1 = GetNumber("Enter a number: ");
            //    var num2 = GetNumber("Enter another number: ");

            //    var sum = 0;
            //    for (int i = num1; i <= num2; i++)
            //    {
            //        sum += i;
            //    }

            //    Console.WriteLine($"The sum of all the number from {num1} to {num2} is {sum}");
                
            //} while (PromptToContinue()); 

            //Console.WriteLine("Adios amigo");

            // Creating Array's
            var length = 10;
            var myArray1 = new int[5];// new string[5];
            myArray1[2] = 2;
            myArray1[3] = 5;
            myArray1[2] = 5;

            Console.WriteLine(myArray1[0]);
            Console.WriteLine(myArray1[1]); // 5
            Console.WriteLine(myArray1[2]); // 2
            Console.WriteLine(myArray1[3]);
            Console.WriteLine(myArray1[4]);

            // Looping Array's
            var myArray2 = new[] { "Jason", "Timothy", "Robert" }; // new string[3] { "Jason", "Timothy", "Robert" };
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }

            foreach (var item in myArray2)
            {
                Console.WriteLine(item);
            }

            // Copying Array's
            var myArray3 = new int[10];
            myArray1.CopyTo(myArray3, 0);

            // Two-Dimensional Array's (Rectangular Array)
            var myArray4 = new int[5, 5];
            myArray4[2, 2] = 5; // third row and third column is getting set to 5

            // Two-Dimensional Array's (Jagged Array)
            var myArray5 = new int[5][];
            myArray5[0] = new int[3];
            myArray5[0][1] = 5;
        }

        private static bool PromptToContinue()
        {
            Console.Write("Would you like to continue (y/n)?");
            string userInput = Console.ReadLine();
            while (!userInput.Equals("y", StringComparison.OrdinalIgnoreCase) && !userInput.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Try again: ");
                userInput = Console.ReadLine();
            }

            return userInput.Equals("y", StringComparison.OrdinalIgnoreCase); // userInput == "Y" || userInput == "y" , userInput.ToUpper() == "Y"
        }

        private static int GetNumber(string message)
        {
            Console.Write(message);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Try again: ");
            }

            return result;
        }

        private static bool TryGetName(out string first, out string last)
        {
            first = "Jason";
            last = "Robert";
            return true;
        }

        private static void PrintName(string first, string last)
        {
            first = "Joe";
            last = "Cool";
        }

        private static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static string FindBuildingType(int buildingHeight)
        {
            string buildingTypeString = null;
            if (buildingHeight > 4 && buildingHeight < 10)
            {
                buildingTypeString = "This is an office building";
            }
            else if (buildingHeight > 50)
            {
                buildingTypeString = "This is a super skyscraper";
            }
            else if (buildingHeight > 11 && buildingHeight < 49)
            {
                buildingTypeString = "This is a skyscrapper";
            }
            else if (buildingHeight < 3)
            {
                buildingTypeString = "This is a house";
            }

            return buildingTypeString;
        }
    }
}
