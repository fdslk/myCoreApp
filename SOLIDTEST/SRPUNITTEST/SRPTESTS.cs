using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using SRPTEST;
using SRPTEST.Model;

namespace SRPUNITTEST
{
    public class SRPTESTS
    {
        [Fact]
        public void GivenCircleShapeList_WhenCallAreaCalculator_ThenReturnCollectCircleArea()
        {
            //Give
            var shapes = new List<Shape> {new Circle() {Radius = 2.0}};

            //When
            var AreaResult = new SRPTEST.AreaCalculator().areaCalculator(shapes);

            //Then
            AreaResult.Count.Should().Be(1);
            var circle = AreaResult[0];
            circle.GetType().Should().Be(typeof(Circle));
            circle.Area.Should().Be(Math.PI * Math.Pow(circle.Radius, 2));
        }

        [Fact]
        public void GivenSquareShapeList_WhenCallAreaCalculator_ThenReturnCollectSquareArea()
        {
            //Give
            var shapes = new List<Shape> {new Square() { Width = 2, Length = 4 }};

            //When
            var AreaResult = new SRPTEST.AreaCalculator().areaCalculator(shapes);

            //Then
            AreaResult.Count.Should().Be(1);
            var sqaure = AreaResult[0];
            sqaure.GetType().Should().Be(typeof(Square));
            sqaure.Area.Should().Be(8);
        }
    }
}
