using System;

namespace MainFunc.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    public abstract class AbstractProductA
    {
    }

    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                              " interacts with " + a.GetType().Name);
        }
    }

    public class ProductA1 : AbstractProductA
    {
    }

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    internal class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                              " interacts with " + a.GetType().Name);
        }
    }

    internal class ProductA2 : AbstractProductA
    {
    }

    class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;
        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }
        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}