namespace Day14
{
    public class Square : IShape
    {
        private readonly double _length;

        public Square(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            return _length * _length;
        }
    }
}
