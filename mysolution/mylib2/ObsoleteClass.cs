using System;

namespace mylib2
{
    [Obsolete("ThisClass is obsolete. Use ThisClass2 instead.")]
    public class ObsoleteClass
    {
        public void test()
        {
            Console.WriteLine("test");
        }
    }
}