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
    }
}
