using System;
using System.Collections.Generic;
using System.Linq;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // object.GetType();
            // Car car = new Car();
            // Type type = car.GetType();
            // System.Reflection.MethodInfo[] methodInfos = type.GetMethods();
            // foreach (var item in methodInfos)
            // {
            //     if (item.Name == "get_Speed")
            //     { System.Console.WriteLine(item); }
            // }
            Type t = Type.GetType("ReflectionTest.Car", false, true);
            Console.WriteLine(t.GetMethods().GetLength(0));
            Console.ReadLine();

            StringTest.stringTest();
        }
    }
}
