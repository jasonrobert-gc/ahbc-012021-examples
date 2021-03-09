using System;
using System.Collections;

namespace MockAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = new Town();
            if (town.SurviveTheWinter())
            {
                Console.WriteLine("Survives the winter");
            }
            else
            {
                Console.WriteLine("They all freeze and die terrible deaths!");
            }

            // Creating and initializing a class
            var car = new Car();
            car.Make = "Chrysler";
            car.Model = "300";

            var list = new List(100);
            list.Insert(car);

            Console.WriteLine(list.GetAt(0).Make);
        }
    }
}
