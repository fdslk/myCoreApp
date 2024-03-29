using System;
using FluentAssertions;
using Xunit;
using MainProgram;

namespace MainProgramTest
{
    public class FunctionalProTests
    {
        [Fact]
        public void GivenTwoSatisfiedObject_WhenCallCountFunction_ThenReturnNumberIsTwo()
        {
            //Arrange
            Predicate<object> objectIsString = delegate(object obj) { return obj.GetType() == typeof(string); };
            object[] objectArray = {"test", 1, "test", 2, 3, 4};

            //Act
            var result = FunctionalPro.Count(objectArray, objectIsString);

            //Assert
            result.Should().NotBe(null);
            result.Should().Be(2);
        }

        //TODO: how assert this test
        [Fact]
        public void GiveUsingBlock_WhenCallUse_ThenExecuteOnce()
        {
            //Given
            Action<string> print = Console.WriteLine;
            var str= "test";

            //When
            str.Use(print);
        }

        [Fact]
        public void GivenPartialPow_WhenUseMathPow_ThenReturn32()
        {
            //Given
            Func<double, double, double> pow = Math.Pow;
            Func<double, double> exp = (pow.Partial( 2 ));

            //When
            var v = exp(5);
            var f = pow.Partial(2)(5);

            //Then
            v.Should().Be(32);
            f.Should().Be(32);
        }

        [Fact]
        public void GivenFixPowerNumberIs5_WhenUseMathPowExtension_ThenReturn32()
        {
            //Given
            Func<double, double, double> pow = Math.Pow;
            Func<double, double> exp = (pow.Partial2(5));
            
            //When
            var v = exp(2);
            
            //Then
            v.Should().Be(32);
        }

        [Fact]
        public void GivenFixXCoordinatesIs2AndYIs2AndZIs2_WhenCalculate3Distance_ThenReturnDistanceIs3Point4641016151377544()
        {
            //Given
            Func<double, double, double, double> Distance = CurryFunction.Distance;
            Func<double, double, double> Fix2XDistance = Distance.GetDistance(2);
            Func<double, Func<double, double>> curryMe = x => y => Fix2XDistance(x, y);
            Func<double, double> basedCurryMe = curryMe(2);
            
            //When
            var distance = Fix2XDistance(2, 2);
            var d = curryMe(2)(2);
            var me = basedCurryMe(2);

            //Then
            distance.Should().Be(3.4641016151377544);
            d.Should().Be(3.4641016151377544);
            me.Should().Be(3.4641016151377544);
            
        }

        [Fact]
        public void GivenFixXCoordinatesIs2AndYIs2AndZIs2_WhenCalculate3CurryDistance_ThenReturnDistanceIs3Point4641016151377544()
        {
            //Given
            Func<double, double, double, double> Distance = CurryFunction.Distance;
            var Fix2XDistance = Distance.CurryGetDistances();

            //When
            var distance = Fix2XDistance(2)(2)(2);

            //Then
            distance.Should().Be(3.4641016151377544);
        }
    }
}
