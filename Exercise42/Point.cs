using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise42
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x; 
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public double CalculateDistance(Point point)
        {
            int distX = point.X - X;
            int distY = point.Y - Y;

            return Math.Sqrt(distX * distX + distY * distY);
        }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}
