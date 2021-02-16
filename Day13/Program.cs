using System;
using System.IO;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Static File methods
            //File.Exists("test.txt");
            //File.ReadAllLines("test.txt");
            //File.WriteAllText("test.txt", "asdfasdfasdf");

            // Any time you are working with larger files, you should use the StreamReader / StreamWriter
            // Classes that implement the IDisposable interface should be used with a using statement!
            using (var writer = new StreamWriter("test.txt", true))
            {
                writer.WriteLine("Hello World");
            }

            using (var reader = new StreamReader("test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
