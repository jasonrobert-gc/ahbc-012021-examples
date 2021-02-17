using System;

namespace Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the type of shape: ");
            var shapeType = Console.ReadLine();

            Console.Write("Enter the addl information on the shape: ");
            var parameter = int.TryParse(Console.ReadLine(), out int value) ? value : default;
            
            var shape = ShapeFactory.Instance.Create(shapeType, parameter);
            Console.WriteLine($"The area of your shape is: {shape.GetArea()}");

            //// To prove it is a singleton
            //var shape2 = ShapeFactory.Instance.Create("square", 2);
        }
    }
}
