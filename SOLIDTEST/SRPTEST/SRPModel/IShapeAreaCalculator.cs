namespace SRPTEST.SRPModel
{
    public interface IShapeAreaCalculator
    {
        Shape CalculateBreakDown(Shape shape);

        string shapeType { get; }
    }
}