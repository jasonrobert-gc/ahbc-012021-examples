using System;
using System.Collections.Generic;

namespace Recap01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just looping

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Looping through arrays

            var array = new int[5] { 11, 12, 13, 14, 15 };
            var array2 = new int[6];
            array.CopyTo(array2, 0);
            array2[5] = 16;
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{i} - {array2[i]}");
            }

            // Looping through Lists

            var list = new List<int> { 11, 12, 13, 14, 15 };
            list.Add(16);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} - {list[i]}");
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            // Exactly the same as the following for loop
            //for (int i = 0; i < list.Count; i++)
            //{
            //    var item = list[i];
            //    Console.WriteLine($"{item}");
            //}

            // Methods - one returns, one returns void
            var built = BuildList();
            PrintList(built);

            // Difference between reference types and value types in method parameters
            var mylist = new List<int>();
            mylist.Add(1);
            DoSomethingToAReferenceType(mylist);
            PrintList(mylist);

            var mynumber = 5;
            DoSomethingToAValueType(mynumber);
            Console.WriteLine(mynumber);
        }

        private static void DoSomethingToAReferenceType(List<int> list)
        {
            list.Add(341234132);
        }

        private static void DoSomethingToAValueType(int num)
        {
            num = 6;
        }

        private static List<int> BuildList()
        {
            var list = new List<int> { 11, 12, 13, 14, 15 };
            list.Add(16);

            return list;
        }

        private static void PrintList(List<int> list)
        {
            Console.WriteLine("--------------------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} - {list[i]}");
            }
            Console.WriteLine("--------------------");
        }
    }
}
