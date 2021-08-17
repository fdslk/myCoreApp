using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using SRPTEST.Model;
using SRPTEST.SRPModel;

namespace SRPUNITTEST
{
    public class SRPTESTS
    {
        private readonly AreaCalculator areaCalculator;
        private readonly List<IShapeAreaCalculator> shapeAreaCalculators;
        private readonly CircleAreaCalculator circleAreaCalculator;
        private readonly SquareAreaCalculator squareAreaCalculator;
        public SRPTESTS()
        {
            circleAreaCalculator = new CircleAreaCalculator();
            squareAreaCalculator = new SquareAreaCalculator();
            shapeAreaCalculators = new List<IShapeAreaCalculator> {circleAreaCalculator, squareAreaCalculator};
            areaCalculator = new AreaCalculator(shapeAreaCalculators);
        }    

        [Fact]
        public void GivenCircleShapeList_WhenCallAreaCalculator_ThenReturnCollectCircleArea()
        {
            //Give
            var shapes = new List<SRPTEST.Model.Shape> {new Circle() {Radius = 2.0}};

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
            var shapes = new List<SRPTEST.Model.Shape> {new Square() { Width = 2, Length = 4 }};

            //When
            var AreaResult = new SRPTEST.AreaCalculator().areaCalculator(shapes);

            //Then
            AreaResult.Count.Should().Be(1);
            var sqaure = AreaResult[0];
            sqaure.GetType().Should().Be(typeof(Square));
            sqaure.Area.Should().Be(8);
        }

        #region SRPMODEL
        [Fact]
        public void GivenRadiusIs2_dWhenCalculateCircleArea_ThenReturnCircleAreaIs12point56()
        {
            //Given
            var circle = new SRPTEST.SRPModel.Shape(){
                ShapeType = nameof(CircleAreaCalculator),
                Radius = 2
            };

            //When
            var result = areaCalculator.CalculateBreakDown(circle);

            //Then
            result.Should().NotBeNull();
            result.Area.Should().NotBe(null);
            result.Area.Should().Be(12.57);
        }

        [Fact]
        public void GivenHeightIs2AndWidthIs3_WhenCalculateSquareArea_ThenReturnSquareAreaIs6()
        {
            //Given
            var sqaure = new SRPTEST.SRPModel.Shape(){
                ShapeType = nameof(SquareAreaCalculator),
                Height = 2,
                Width = 3
            };

            //When
            var result = areaCalculator.CalculateBreakDown(sqaure);

            //Then
            result.Should().NotBeNull();
            result.Area.Should().NotBe(null);
            result.Area.Should().Be(6);
        }
        #endregion
    }
}
