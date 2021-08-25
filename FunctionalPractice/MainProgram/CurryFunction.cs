using System;

namespace MainProgram
{
    public static class CurryFunction
    {
        public static double Distance(double x, double y, double z)
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static Func<T2, T3, TR> GetDistance<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func, T1 x){
            return (y, z) => func(x, y, z);
        }

        public static Func<T1, Func<T2, Func<T3, TR>>> CurryGetDistances<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func){
            return x => y => z => func(x, y, z);
        }
    }
}