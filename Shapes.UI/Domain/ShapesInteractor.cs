using Shapes.Core;
using Shapes.UI.Models;

namespace Shapes.UI.Domain
{
    public class ShapesInteractor
    {
        private readonly List<Shape> _shapes = [];

        internal async Task AddShape(DTO shape)
        {
            await Task.Delay(0); await Task.Delay(0);
            if (shape.Values.Length == 1)
            {
                _shapes.Add(new Circle(shape.Values[0]));
            }
            else if (shape.Values.Length == 3)
            {
                _shapes.Add(new Triangle(shape.Values[0], shape.Values[1], shape.Values[2]));
            }
            else
            {
                throw new NotImplementedException("Неизвестный тип фигуры");
            }
        }


        internal async Task<List<string>> GetDescriptions()
        {
            await Task.Delay(0); await Task.Delay(0);
            List<string> result = [];
            foreach (var shape in _shapes)
            {
                string content = shape.GetDescription() + ", с площадью " + shape.GetArea() + ".";
                if (shape is Triangle triangle)
                {
                    if (triangle.IsOrtho())
                        content = content.Insert(content.Length - 1, ", прямоугольный");
                }
                result.Add(content);
            }
            return result;
        }
    }
}
