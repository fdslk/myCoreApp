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
            var lazySingleObject = LazyManWithoutThreadSafe.GetInstance();

            Parallel.For(0, 500000000000000, (i, loopstate) =>
              {
                //   singleObject.add();
                lazySingleObject.add();
                if(i == 100){
                    loopstate.Break();
                }
              });

        }    
    }
}
