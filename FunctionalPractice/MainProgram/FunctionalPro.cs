using System;

namespace MainProgram
{
    public static class FunctionalPro
    {
        public static int Count<T>(T[] objectArray, Predicate<T> condition)
        {
            int counter = 0;
            foreach (var obj in objectArray)
            {
                if (condition(obj))
                {
                    counter++;
                }
            }

            return counter;
        }
        
        public static void Use<T>(this T obj, Action<T> action)
        {
            action(obj);
        }
    }
}
