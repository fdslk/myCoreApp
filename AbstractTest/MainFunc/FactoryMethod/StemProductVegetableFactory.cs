namespace MainFunc.FactoryMethod
{
    public class StemProductVegetableFactory: ProductVegetableFactory
    {
        public Vegetable Product()
        {
            return new StemVegetable();
        }
    }
}