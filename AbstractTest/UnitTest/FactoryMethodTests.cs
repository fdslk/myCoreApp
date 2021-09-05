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
            var rootVegetableFactory = new RootProductVegetableFactory();

            //When
            var vegetable = rootVegetableFactory.Product();

            //Then
            vegetable.GetType().Name.Should().Be(nameof(RootVegetable));
        }
        
        [Fact]
        public void GivenStemVegetableFactory_WhenCallProduct_ThenReturnStemVegetable()
        {
            //Given
            var stemVegetableFactory = new StemProductVegetableFactory();

            //When
            var vegetable = stemVegetableFactory.Product();

            //Then
            vegetable.GetType().Name.Should().Be(nameof(StemVegetable));
        }

        [Fact]
        public void GivenStemProductVegetableType_WhenCallGetVegetableFactory_ReturnStemProductVegetableFactory()
        {
            //Given
            var vegetableFactory = new VegetableFactory();

            //When
            var productVegetableFactory = vegetableFactory.GetProductVegetableFactory(nameof(StemProductVegetableFactory));

            //Then
            productVegetableFactory.GetType().Name.Should().Be(nameof(StemProductVegetableFactory));
        }
        
        [Fact]
        public void GivenRootProductVegetableType_WhenCallGetVegetableFactory_ReturnRootProductVegetableFactory()
        {
            //Given
            var vegetableFactory = new VegetableFactory();

            //When
            var productVegetableFactory = vegetableFactory.GetProductVegetableFactory(nameof(RootProductVegetableFactory));

            //Then
            productVegetableFactory.GetType().Name.Should().Be(nameof(RootProductVegetableFactory));
        }
    }
}