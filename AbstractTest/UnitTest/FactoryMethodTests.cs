using FluentAssertions;
using MainFunc.FactoryMethod;
using Xunit;

namespace UnitTest
{
    public class FactoryMethodTests
    {
        [Fact]
        public void GivenRootVegetableFactory_WhenCallProduct_ThenReturnRootVegetable()
        {
            //Given
            var rootVegetableFactory = new RootVegetableFactory();

            //When
            var vegetable = rootVegetableFactory.Product();

            //Then
            vegetable.GetType().Name.Should().Be(nameof(RootVegetable));
        }
        
        [Fact]
        public void GivenStemVegetableFactory_WhenCallProduct_ThenReturnStemVegetable()
        {
            //Given
            var stemVegetableFactory = new StemVegetableFactory();

            //When
            var vegetable = stemVegetableFactory.Product();

            //Then
            vegetable.GetType().Name.Should().Be(nameof(StemVegetable));
        }
    }
}