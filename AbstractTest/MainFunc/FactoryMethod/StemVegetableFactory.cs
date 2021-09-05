namespace MainFunc.FactoryMethod
{
    public class StemVegetableFactory: VegetableFactory
    {
        public Vegetable Product()
        {
            return new StemVegetable();
        }
    }
}