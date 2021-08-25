using System;

namespace MainProgram
{
    public static class PartialFunction
    {
        public static Func<T2, TR> Partial<T1, T2, TR>(this Func<T1, T2, TR> func, T1 first)
        {
            return (x) => func(first, x);
        }
        public static Func<T1, TR> Partial2<T1, T2, TR>(this Func<T1, T2, TR> func, T2 second){
            return x=>func(x, second);
        }
    }
}
