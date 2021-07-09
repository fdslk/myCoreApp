using System;
using System.Threading.Tasks;
using DemoSingle;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleObject = SingleObject.GetInstance();
            singleObject.ShowMessage();
            var lazySingleObjectWithSafe = LazyManWithThreadSafe.GetInstance();
            var lazySingleObjectWithoutSafe = LazyManWithoutThreadSafe.GetInstance();

            Parallel.For(0, 500000000000000, (i, loopstate) =>
              {
                // singleObject.add();
                // lazySingleObjectWithSafe.add();
                lazySingleObjectWithoutSafe.add();
                if(i == 100){
                    loopstate.Break();
                }
              });

        }    
    }
}
