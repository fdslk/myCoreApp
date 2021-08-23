using System;

namespace MainProgram
{
    public class FunctionalPro
    {
        public int Count<T>(T[] objectArray, Predicate<T> condition)
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
    }
}
