using System;
using System.Collections.Generic;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fanzy way to initialize properties
            var dog = new Dog
            {
                // Enum when you have a specific set of values you want to represent
                EarType = DogEarType.Floppy
            };

            //// The previous statement is the same as the following
            //var dog = new Dog();
            //dog.EarType = DogEarType.Floppy;

            // Polymorphism - You can refer to a child class as its base class
            Animal animal1 = new Dog();

            // This also can be used when providing parameters
            Print(new Cat());
            Print(dog);
            Print(new GermanShepherd());
            Print(new Bird());

            Console.WriteLine("--------------");

            // Fanzy way to initialize a collection
            var animals = new List<Animal>
            {
                new Dog(),
                new Dog(),
                new Cat()
            };

            //// The previous statement is the same as the following
            //var animals = new List<Animal>();
            //animals.Add(new Dog());
            //animals.Add(new Dog());
            //animals.Add(new Cat());

            var cat = new Cat();
            animals.Add(cat);

            foreach (var animal in animals)
            {
                Print(animal);
            }
        }

        private static void Print(Animal animal)
        {
            //// Unsafe cast
            //// System.InvalidCastException: 'Unable to cast object of type 'Day11.Cat' to type 'Day11.Dog'.'
            //var dog = (Dog)animal;

            //// Safe cast - Can be used with reference types only
            //var dog = animal as Dog;
            //if (dog != null)
            //{
            //    dog.BiteAStranger();
            //}

            // Pattern matching, preferred over the previous two examples
            if (animal is Dog dog)
            {
                dog.BiteAStranger();
            }

            Console.WriteLine($"{animal.GetType()} - {animal.MakeSound()}");
        }
    }
}
