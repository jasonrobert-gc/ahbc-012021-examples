using System;
using System.Collections.Generic;

namespace Exercise52
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string response;
            do
            {
                Run();
                Console.Write("Would you like to continue (y/n)?");
                response = Console.ReadLine();
            } while (response.Equals("y", StringComparison.OrdinalIgnoreCase));
        }

        private static void Run()
        {
            bool quit;
            var shapes = new List<IShape>();
            do
            {
                Console.Write("Enter a new shape.  Square (1), Triangle (2), Circle(3), Quit(q):");
                var response = Console.ReadLine();
                quit = false;
                if (response.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    quit = true;
                }
                else if (!int.TryParse(response, out int number) || number < 1 || number > 3)
                {
                    Console.WriteLine("You must enter a valid option!");
                    continue;
                }
                else
                {
                    shapes.Add(GetShape(number));
                }
            } while (!quit);

            double totalArea = 0;
            double totalPerimeter = 0;
            foreach (var item in shapes)
            {
                totalArea += item.GetArea();
                totalPerimeter += item.GetPerimeter();
            }

            Console.WriteLine($"Average Area: {totalArea / shapes.Count}");
            Console.WriteLine($"Average Perimeter: {totalPerimeter / shapes.Count}");
        }

        private static IShape GetShape(int shapeType)
        {
            switch (shapeType)
            {
                case 1:
                    return new Square(GetNumber("Enter a side length:"));
                case 2:
                    return new Triangle(
                        GetNumber("Enter the length of side 1:"), 
                        GetNumber("Enter the length of side 2:"), 
                        GetNumber("Enter the length of side 3:"));
                case 3:
                    return new Circle(GetNumber("Enter the radius:"));
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeType));
            }
        }

        private static int GetNumber(string message)
        {
            int result;
            Console.Write(message);
            var response = Console.ReadLine();
            while (!int.TryParse(response, out result))
            {
                Console.Write("Oops! You didn't enter a number! Try again: ");
                response = Console.ReadLine();
            }

            return result;
        }
    }
}
