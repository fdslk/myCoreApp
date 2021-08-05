using System.Collections.Generic;
using System.Linq;

namespace SRPTEST.SRPModel
{
    public class AreaCalculator: IAreaCalculator
    {
        private readonly List<IShapeAreaCalculator> _calcuators = new List<IShapeAreaCalculator>();

        public AreaCalculator(IEnumerable<IShapeAreaCalculator> shapeAreaCalculators){
            _calcuators.AddRange(shapeAreaCalculators);
        }

        public Shape CalculateBreakDown(Shape shape)
        {
            return _calcuators
            .First(x => 
            shape.ShapeType.Equals(x.GetType().Name))
            .CalculateBreakDown(shape);
        }
    }
}
