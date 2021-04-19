using System;

namespace AttributePrc
{
    [AttributeUsage(AttributeTargets.Method)]//limit the scope of usage
    public class AnimalTypeAttribute : Attribute
    {
        protected Animal thePet;
        public AnimalTypeAttribute(Animal pet)
        {
            thePet = pet;
        }

        public Animal ThePet
        {
            get => thePet;
            set => thePet = value;
        }
    }
}