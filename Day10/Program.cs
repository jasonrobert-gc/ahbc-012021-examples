using System;
using System.Collections.Generic;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            Console.Write("Enter the license plate: ");
            var plate = Console.ReadLine();
            Console.Write("Enter the year: ");
            var year = int.TryParse(Console.ReadLine(), out var result) ? result : default; // Ternary operator, very helpful
            vehicles.Add(new Car(plate, year));

            Console.Write("Enter the license plate: ");
            plate = Console.ReadLine();
            Console.Write("Enter the year: ");
            year = int.TryParse(Console.ReadLine(), out result) ? result : default; // 'default' returns the default value of a type
            vehicles.Add(new Vehicle(plate, year));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Print());
            }
        }
    }
}
