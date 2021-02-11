using System;
using System.Collections.Generic;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Dog(),
                new Cat()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }
    }
}
