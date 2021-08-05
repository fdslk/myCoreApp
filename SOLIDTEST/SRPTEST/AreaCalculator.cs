using System;
using System.Collections.Generic;
using SRPTEST.Model;

namespace SRPTEST
{
    public class AreaCalculator
    {
        public List<Shape> areaCalculator(List<Shape> shapes){
            foreach (var shape in shapes)
            {
                if(shape.GetType() == typeof(Circle)){
                    shape.Area = Math.PI * Math.Pow(shape.Radius, 2);
                }
                if(shape.GetType() == typeof(Square)){
                    shape.Area = shape.Width * shape.Length;
                }
            }

            return shapes;
        }
    }
}
