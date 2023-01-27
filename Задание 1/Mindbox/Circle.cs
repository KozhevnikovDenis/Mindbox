namespace Mindbox
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius 
        {
            private get => radius;
            set => radius = CheckPositivity(value);
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
        private double CheckPositivity(double radius)
        {
            if (radius <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(radius), "error: radius must be > 0");
            return radius;
        }
    }
}
