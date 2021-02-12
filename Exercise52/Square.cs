namespace Exercise52
{
    public class Square : IShape
    {
        public Square(double length)
        {
            Length = length;
        }

        public double Length { get; }

        public double GetArea()
        {

            return Length * Length;
        }

        public double GetPerimeter()
        {
            return (Length + Length) * 2;
        }
    }
}
