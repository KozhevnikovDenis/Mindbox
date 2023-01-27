namespace Mindbox
{
    public class Triangle : Figure
    {
        private double sideA, sideB, sideC;
        public double SideA
        { 
            private get => sideA; 
            set => sideA = CheckPositivity(value);
        }
        public double SideB
        {
            private get => sideB; 
            set => sideB = CheckPositivity(value);
        }
        public double SideC
        {
            private get => sideC;
            set => sideC = CheckPositivity(value);
        }
        private double Perimeter => SideA + SideB + SideC;
        private double MaxSide => Math.Max(SideA, Math.Max(SideB, SideC));
        public override double GetArea()
        {
            CheckExistence();
            CheckRightTriangle(SideA, SideB, SideC);
            return Math.Sqrt(0.5 * Perimeter * (0.5 * Perimeter - SideA) * (0.5 * Perimeter - SideB) * (0.5 * Perimeter - SideC));
        }
        private double CheckPositivity(double side)
        {
            if (side <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(side), "error: all sides must be > 0");
            return side;
        }
        private void CheckExistence()
        {
            if (MaxSide >= Perimeter - MaxSide)
                throw new ArgumentException("error: triangle not exists");
        }
        private void CheckRightTriangle(double a, double b, double c)
        {
            if (MaxSide == a)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    Console.WriteLine("right triangle");
                else
                    Console.WriteLine("not right triangle");
            }
            if (MaxSide == b)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                    Console.WriteLine("right triangle");
                else
                    Console.WriteLine("not right triangle");
            }
            if (MaxSide == c)
            {
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    Console.WriteLine("right triangle");
                else
                    Console.WriteLine("not right triangle");
            }
        }
    }
}
