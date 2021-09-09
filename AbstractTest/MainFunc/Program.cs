using System;
using AbstractFactoryDesignPatternInCSharp;
using MainFunc.AbstractFactory;
using MainFunc.simpleFactory;

namespace MainFunc
{
    static class Program
    {
        static void Main(string[] args)
        {
            var rootVegetableFactory = new RootVegetableFactory();
            var vegetableProvider = new VegetableProvider(rootVegetableFactory);
            vegetableProvider.ProductGenericVegetable();
            vegetableProvider.ProductNonGenericVegetable();
            
            var stemVegetableFactory = new StemVegetableFactory();
            vegetableProvider = new VegetableProvider(stemVegetableFactory);
            vegetableProvider.ProductGenericVegetable();
            vegetableProvider.ProductNonGenericVegetable();
        }
    }
}
