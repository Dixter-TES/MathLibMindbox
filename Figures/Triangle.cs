namespace MathLibMindbox.Figures
{
    public class Triangle : IFigure
    {
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area()
        {
            if (A <= 0 || B <= 0 || C <= 0)
                throw new ArgumentOutOfRangeException("Side", "The side must be a positive number");

            // Проверка на прямоугольный треугольник
            if ((Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2))
                || (Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2))
                || (Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2)))
                return 0.5d * A * C;

            double p = (A + B + C) / 2;

            return Math.Sqrt(p * ((p - A) * (p - B) * (p - C)));
        }
    }
}
