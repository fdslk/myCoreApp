namespace MainFunc.simpleFactory
{
    public class VegetableFactory{
        public Vegetable GetVegetable(string type)
        {
            return type switch
            {
                nameof(Cabbage) => new Cabbage(),
                nameof(Bean) => new Bean(),
                nameof(Carrot) => new Carrot(),
                _ => null
            };
        }
    }
}