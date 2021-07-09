using System.Threading;

namespace DemoSingle
{
    public class LazyManWithThreadSafe
    {
        private volatile static LazyManWithThreadSafe instance;

        private static int count = 0;

        private LazyManWithThreadSafe() { }

        public static LazyManWithThreadSafe GetInstance()
        {
            if (instance == null)
            {
                lock (typeof(LazyManWithThreadSafe))
                {
                    if (instance == null)
                    {
                        instance = new LazyManWithThreadSafe();
                    }
                }
            }
            return instance;
        }

        public void add()
        {
            count++;
            System.Console.WriteLine($"{count}");
        }
    }
}