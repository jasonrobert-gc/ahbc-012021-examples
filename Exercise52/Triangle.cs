namespace Exercise52
{
    public class Triangle : IShape
    {
        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }

        public double GetArea()
        {
            return (ASide * BSide) / 2;
        }

        public double GetPerimeter()
        {
            return ASide + BSide + CSide;
        }
    }
}
