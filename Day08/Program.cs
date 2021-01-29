using System;
using System.Collections;
using System.Collections.Generic;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            // non-generic collections - Loosely Typed - Legacy
            var arrayList = new ArrayList();
            arrayList.Add(1234);
            arrayList.Add("1234");

            // Generic Collections - Strongly Typed - Has "Type Safety"
            // LISTS
            var list = new List<double>();
            list.Add(1234);
            // list.Add("1234"); this will give an error

            var num1 = list[0]; // I know with 100% certainty this will give me an int!

            // Looping through with a for loop (use .Count for lists, .Length for arrays)
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Looping through with a foreach loop (Preferred)
            foreach (var num in list)
            {
                Console.WriteLine(num);
            }

            // DICTIONARIES
            var dictionary = new Dictionary<double, string>();
            dictionary.Add(1.1, "One dot one");
            Console.WriteLine(dictionary[1.1]);

            // Splitting a string
            var sentence = "Please excuse my dear aunt Sally";
            var words = sentence.Split();
        }
    }
}
