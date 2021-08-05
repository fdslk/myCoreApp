using System;

namespace SRPTEST.SRPModel
{
    public class SquareAreaCalculator : IShapeAreaCalculator
    {
        public string shapeType => typeof(SquareAreaCalculator).Name;
        public Shape CalculateBreakDown(Shape shape)
        {
            var square = new Shape();
            square.Area = shape.Height * shape.Width;
            square.Perimeter = 2 * (shape.Height + shape.Width);    
            return square;
        }
    }
}
