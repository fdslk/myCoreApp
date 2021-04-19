namespace AttributePrc
{
    public class AnimalAttributeTest
    {
        [AnimalType(Animal.Dot)]
        public void DogMethod(){}
        [AnimalType(Animal.Cat)]
        public void CatMethod(){}
        [AnimalType(Animal.Bird)]
        public void BirdMethod(){}
    }
}