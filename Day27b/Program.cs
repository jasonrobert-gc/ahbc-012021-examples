using System;
using System.Collections.Generic;
using System.Linq;

namespace Day27b
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new[] {"Hello", "World", "Jason", "Robert"};

            //// Without Linq
            //var results = new List<string>();
            //foreach (var item in items)
            //{
            //    if (item.StartsWith("J"))
            //    {
            //        results.Add(item);
            //    }
            //}

            //// The Query Syntax
            //var results = from item in items
            //              where item.StartsWith("J")
            //              select item; 

            //// The Method Syntax
            //var results = items.Where(item => item.StartsWith("J"));

            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}

            //// Common Linq Methods
            //var results = items.FirstOrDefault(x => x.StartsWith("Z"));
            //var results = items.SingleOrDefault(x => x.Length == 5);
            //var results = items.Any();
            //var results = items.Any(x => x.StartsWith("~"));
            //Console.WriteLine(results);

            var results = items.Select(x => x.Length);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            var resultsArray = results.ToArray();
            var resultsList = results.ToList();
        }
    }
}
