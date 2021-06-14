using System;

namespace TestDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            B b = new B(a);

            C c = new C(a);

            a.Raise("left");

            a.Raise("right");

            a.Fall();

            Console.ReadLine();
        }
    }
}
