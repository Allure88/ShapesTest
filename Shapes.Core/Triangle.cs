namespace Shapes.Core;

public class Triangle : Shape
{
    private const double COMPARE_TOLERANCE = 1e-6;
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Введено отрицательное значение");

        static bool IsValidTriangle(double a, double b, double c) => a + b > c && a + c > b && b + c > a;

        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("Не удалось создать треугольник по данным сторонам.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double GetArea()
    {
        double halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }

    public bool IsOrtho()
    {
        List<double> sides = [SideA, SideB, SideC];
        sides.Sort();

        double leftExp = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        double rightExp = Math.Pow(sides[2], 2);
        return Math.Abs(leftExp - rightExp) < COMPARE_TOLERANCE;
    }

    public override string GetDescription() => $"Треугольник со сторонами {SideA}, {SideB}, {SideC}";
}
