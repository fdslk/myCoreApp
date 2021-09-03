namespace MainFunc.simpleFactory
{
    class Carrot : Vegetable
    {
        public void fruit()
        {
            System.Console.WriteLine("Carrot gets fuirt.");
        }

        public void grow()
        {
            System.Console.WriteLine("Carrot grows up.");
        }

        public void sow()
        {
            System.Console.WriteLine("Carrot is borned up.");
        }
    }
}