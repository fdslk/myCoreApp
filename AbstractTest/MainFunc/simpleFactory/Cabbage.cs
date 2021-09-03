namespace MainFunc.simpleFactory
{
    class Cabbage : Vegetable
    {
        public void fruit()
        {
            System.Console.WriteLine("Cabbage gets fuirt.");
        }

        public void grow()
        {
            System.Console.WriteLine("Cabbage grows up.");
        }

        public void sow()
        {
            System.Console.WriteLine("Cabbage is borned up.");
        }
    }
}