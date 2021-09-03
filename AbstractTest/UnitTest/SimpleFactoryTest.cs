using FluentAssertions;
using MainFunc.simpleFactory;
using Xunit;

namespace UnitTest
{
    public class SimpleFactoryTest
    {
        private readonly VegetableFactory _vegetableFactory;
        
        public SimpleFactoryTest()
        {
            _vegetableFactory = new VegetableFactory();
        }
        
        [Fact]
        public void GivenBeanType_WhenGetVegetable_ThenReturnBean()
        {
            //Given
            var vegetable = _vegetableFactory.GetVegetable("Bean");

            //When

            //Then
            vegetable.GetType().Name.Should().Be("Bean");
        }
        
        [Fact]
        public void GivenCabbageType_WhenGetVegetable_ThenReturnCabbage()
        {
            //Given
            var vegetable = _vegetableFactory.GetVegetable("Cabbage");

            //When

            //Then
            vegetable.GetType().Name.Should().Be("Cabbage");
        }
        
        [Fact]
        public void GivenCarrotType_WhenGetVegetable_ThenReturnCarrot()
        {
            //Given
            var vegetable = _vegetableFactory.GetVegetable("Carrot");

            //When

            //Then
            vegetable.GetType().Name.Should().Be("Carrot");
        }
    }
}
