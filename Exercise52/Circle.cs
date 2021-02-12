using System;

namespace Exercise52
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return (2 * Math.PI * Radius);
        }
    }
}
