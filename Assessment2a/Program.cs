using System;
using System.Collections.Generic;

namespace Assessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddValues("one", "two", "three"));
            Console.WriteLine(SumArray(new int[] { 1, 2, 3}));
            Console.WriteLine(RemoveNum(new List<int> {1, 2, 3 }, 2));
            Console.WriteLine(AddToList("kiwi"));
            Console.WriteLine(TryMe(1, 0));
        }

        private static string[] AddValues(string one, string two, string three)
        {
            string[] value = {one, two, three};
            return value;
        }

        private static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }

        private static List<int> RemoveNum(List<int> list, int num)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == num)
                {
                    list.RemoveAt(i);
                }
            }

            // OR

            if (list.Contains(num))
            {
                list.Remove(num);
            }

            return list;
        }

        private static List<string> AddToList(string value)
        {
            List<string> fruits = new List<string>();
            fruits.Add("grapes");
            fruits.Add("oranges");
            fruits.Add(value);
            return fruits;
        }

        private static int TryMe(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (ArithmeticException)
            {
                return 9;
            }
        }
    }
}
