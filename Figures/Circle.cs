namespace MathLibMindbox.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            if (Radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(Radius), "The radius must be a positive number");

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
