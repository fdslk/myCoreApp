using System;
using System.Reflection.Metadata.Ecma335;

namespace MainFunc.AbstractFactory
{
    public interface VegetableAbstractFactory
    {
        IGenericVegetable ProductGenericVegetable();
        INonGenericVegetable ProductNonGenericVegetable();
    }

    public interface INonGenericVegetable
    {
        void ProductVegetable();
    }

    public interface IGenericVegetable
    {
        void ProductVegetable();
    }

    public class RootVegetableFactory : VegetableAbstractFactory
    {
        public IGenericVegetable ProductGenericVegetable()
        {
            return new RootGenericVegetable();
        }

        public INonGenericVegetable ProductNonGenericVegetable()
        {
            return new RootNonGenericVegetable();
        }
    }

    public class RootNonGenericVegetable : INonGenericVegetable
    {
        public void ProductVegetable()
        {
            Console.WriteLine($"{nameof(RootNonGenericVegetable)}");
        }
    }

    public class RootGenericVegetable : IGenericVegetable
    {
        public void ProductVegetable()
        {
            Console.WriteLine($"{nameof(RootGenericVegetable)}");
        }
    }

    public class StemVegetableFactory : VegetableAbstractFactory
    {
        public IGenericVegetable ProductGenericVegetable()
        {
            return new StemGenericVegetable();
        }

        public INonGenericVegetable ProductNonGenericVegetable()
        {
            return new StemNonGenericVegetable();
        }
    }

    public class StemNonGenericVegetable : INonGenericVegetable
    {
        public void ProductVegetable()
        {
            Console.WriteLine($"{nameof(StemNonGenericVegetable)}");
        }
    }

    public class StemGenericVegetable : IGenericVegetable
    {
        public void ProductVegetable()
        {
            Console.WriteLine($"{nameof(StemGenericVegetable)}");
        }
    }

    public class VegetableProvider
    {
        private readonly IGenericVegetable _genericVegetable;
        private readonly INonGenericVegetable _nonGenericVegetable;

        public VegetableProvider(VegetableAbstractFactory factory)
        {
            _genericVegetable = factory.ProductGenericVegetable();
            _nonGenericVegetable = factory.ProductNonGenericVegetable();
        }

        public void ProductGenericVegetable()
        {
            _genericVegetable.ProductVegetable();
        }
        
        
        public void ProductNonGenericVegetable()
        {
            _nonGenericVegetable.ProductVegetable();
        }
    }
}