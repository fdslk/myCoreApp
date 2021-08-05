using System;

namespace SRPTEST.SRPModel
{
    public class CircleAreaCalculator: IShapeAreaCalculator
    {
        public string shapeType => typeof(CircleAreaCalculator).Name;

        public Shape CalculateBreakDown(Shape shape)
        {
            var circle = new Shape();

            circle.Area = Math.PI * Math.Pow(shape.Radius, 2);
            circle.Perimeter = 2 * Math.PI * shape.Radius;

            return circle;
        }
    }
}
