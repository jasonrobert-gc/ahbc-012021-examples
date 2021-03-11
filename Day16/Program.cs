using System; 
using System.Linq;
using System.Collections.Generic;

namespace Day16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] unsorted = { 56, 23, 57, 2 };
            Print(unsorted);
            var sorted = MergeSort(unsorted.ToList());
            Print(sorted);

            // Assessment 3 - Prep
            var garage = new Garage();
            garage.Cars.Add(new Car("Chrysler", "300"));
            garage.Capacity = 5;
            if (garage.DoTheyFit())
            {
                Console.WriteLine("They fit");
            }
            else
            {
                Console.WriteLine("They do not fit");
            }
            // End assessment prep
        }

        public static void PrintVehicleWheels(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetNumberOfWheels());
        }

        public static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        public static bool LinearSearch(int[] unsorted, int value)
        {
            foreach (var item in unsorted)
            {
                if (item == value)
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] SelectionSort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    // checking if we need to swap
                    if (unsorted[i] > unsorted[j])
                    {
                        // swapping
                        var temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }

            return unsorted;
        }

        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            var left = new List<int>();
            var right = new List<int>();
            var middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            return result;
        }

        public static void Print(IEnumerable<int> values)
        {
            Console.WriteLine(string.Join(", ", values));
        }
    }
}
