using System;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var x = GetNumber("Enter an X coordinate: ");
                var y = GetNumber("Enter a Y coordinate: ");

                var origin = new Point(0, 0);
                var point = new Point(x, y);

                Console.WriteLine($"You have created a point object {point.Print()}. " +
                                  $"It has a distance of {Math.Round(point.CalculateDistance(origin))}");
                Console.Write("Would you like to try again? ");

            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }

        private static int GetNumber(string message)
        {
            Console.Write(message);
            var response = Console.ReadLine();

            int result;
            while (!int.TryParse(response, out result))
            {
                Console.Write("Invalid entry, please enter a number: ");
                response = Console.ReadLine();
            }

            return result;
        }
    }
}
