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

            var num1 = list[0]; // I know with 100% certainty this will give me a double!

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

            // Finding an item in my list
            double result;
            foreach (var num in list)
            {
                if (num > 10)
                {
                    result = num;
                    break;
                }
            }

            // DICTIONARIES
            var dictionary = new Dictionary<double, string>();
            dictionary.Add(1.1, "One dot one");
            Console.WriteLine(dictionary[1.1]);

            // Splitting a string
            var sentence = "Please excuse my dear aunt Sally";
            var words = sentence.Split();
            var original = string.Join(' ', words);

            // STACKS (LIFO) Last in, First out
            var myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            Console.WriteLine(myStack.Pop()); 
            Console.WriteLine(myStack.Peek()); 
            Console.WriteLine(myStack.Peek()); 
            Console.WriteLine(myStack.Peek()); 
            Console.WriteLine(myStack.Peek()); 
            Console.WriteLine(myStack.Pop());

            if (myStack.TryPop(out var top))
            {
                Console.WriteLine(top);
            }

            // QUEUE (FIFO) First in, First out
            var queue = new Queue<string>();
            queue.Enqueue("Good");
            queue.Enqueue("Bye");
            Console.WriteLine(queue.Dequeue()); // Hello
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue()); // World

            if (queue.TryDequeue(out var first))
            {
                Console.WriteLine(first);
            }
        }
    }
}