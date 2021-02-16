using System;

namespace Day14
{
    public class Triangle : IShape
    {
        private readonly double _length;

        public Triangle(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(_length, 2);
        }
    }
}
