namespace Shapes.Core;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус отрицательный.");
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string GetDescription() => $"Круг с раудиусом {Radius}";
}
