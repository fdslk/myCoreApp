using System;
using System.Reflection;
using mylib2;
using AttributePrc;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeInfo = typeof(AnimalAttributeTest).GetTypeInfo();
            foreach (var type in typeInfo.GetMethods())
            {
                foreach (var customAttribute in Attribute.GetCustomAttributes(type))
                {
                    if (customAttribute.GetType() == typeof(AnimalTypeAttribute))
                    {
                        Console.WriteLine($"Method{type.Name} has a pet {(((AnimalTypeAttribute)customAttribute).ThePet == Animal.Bird)} attribute");
                    }
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
