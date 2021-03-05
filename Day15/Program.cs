using System;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List(10);
            list.Insert("one");
            list.Insert("two"); 
            list.Insert("three");
            list.Insert("four");

            list.RemoveAt(1);
            list.RemoveAt(0);
        }
    }
}
