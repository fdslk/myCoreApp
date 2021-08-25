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
    }
}