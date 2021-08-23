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
            var functionalPro = new FunctionalPro();

            //Act
            var result = functionalPro.Count(objectArray, objectIsString);

            //Assert
            result.Should().NotBe(null);
            result.Should().Be(2);
        }
    }
}
