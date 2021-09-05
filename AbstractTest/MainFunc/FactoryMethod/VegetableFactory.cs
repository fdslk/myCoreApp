namespace MainFunc.FactoryMethod
{
    public class VegetableFactory
    {
        public ProductVegetableFactory GetProductVegetableFactory(string type)
        {
            return type switch
            {
                nameof(RootProductVegetableFactory) => new RootProductVegetableFactory(),
                nameof(StemProductVegetableFactory) => new StemProductVegetableFactory(),
                _ => null
            };
        }
    }
}