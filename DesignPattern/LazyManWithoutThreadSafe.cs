using System.Threading;

namespace DemoSingle
{
    public class LazyManWithoutThreadSafe
    {
        private volatile static LazyManWithoutThreadSafe instance;

        private static int count = 0;

        private LazyManWithoutThreadSafe() { }

        public static LazyManWithoutThreadSafe GetInstance()
        {
            if (instance == null)
            {
                lock (typeof(LazyManWithoutThreadSafe))
                {
                    if (instance == null)
                    {
                        instance = new LazyManWithoutThreadSafe();
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