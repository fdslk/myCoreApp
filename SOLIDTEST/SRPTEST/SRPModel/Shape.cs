using System;

namespace SRPTEST.SRPModel
{
    public class Shape
    {
        private double area;
        private double perimeter;
        private int height;
        private int width;
        private int radius;
        private string shapeType;
        public double Area { get => area; set => area = value; }
        public double Perimeter { get => perimeter; set => perimeter = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int Radius { get => radius; set => radius = value; }
        public string ShapeType { get => shapeType; set => shapeType = value; }
    }
}
