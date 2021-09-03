namespace MainFunc.simpleFactory
{
    class Bean : Vegetable
    {
        public void fruit()
        {
            System.Console.WriteLine("Bean gets fuirt.");
        }

        public void grow()
        {
            System.Console.WriteLine("Bean grows up.");
        }

        public void sow()
        {
            System.Console.WriteLine("Bean is borned up.");
        }
    }
}