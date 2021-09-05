using MainFunc.simpleFactory;

namespace MainFunc.FactoryMethod
{
    public class RootProductVegetableFactory: ProductVegetableFactory
    {
        public Vegetable Product()
        {
            return new RootVegetable();
        }
    }
}