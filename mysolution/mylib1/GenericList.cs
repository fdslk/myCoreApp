// Declare the generic class.
using System.Collections.Generic;

namespace mylib1{
    public class GenericList<T> where T : Class1
    {
        public void Add(T input) { }
    }
    public static class TestGenericList
    {
        private class ExampleClass { }
        public static void Main()
        {
            // Declare a list of type ExampleClass.
            GenericList<Class1> list3 = new GenericList<Class1>();
            // list3.Add(new Class1());
            System.Console.WriteLine(list3.ToString());
        }
        //TODO: implement unitTest
        public static List<T> GetUniqueList<T>(this List<T> list){
            List<T> tmp = new List<T>();
            for (int i = 0; i < list.Count; i ++)
            {
                if(!tmp.Contains(list[i])){
                    tmp.Add(list[i]);
                }
            }
            return tmp;
        }
    }
}