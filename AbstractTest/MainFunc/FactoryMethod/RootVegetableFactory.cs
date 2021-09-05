using MainFunc.simpleFactory;

namespace MainFunc.FactoryMethod
{
    public class RootVegetableFactory: VegetableFactory
    {
        public Vegetable Product()
        {
            return new RootVegetable();
        }
    }
}