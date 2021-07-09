using System.Threading;

namespace DemoSingle
{
    public class SingleObject{
           private static SingleObject instance = new SingleObject();

           private static int innerCounter = 0;

           private SingleObject(){}

           public static SingleObject GetInstance(){
               return instance;
           }

           public void ShowMessage(){
               System.Console.WriteLine("hello, I'm a single object.");
           }

           public void add(){
               innerCounter++;
               System.Console.WriteLine($"{innerCounter}");
               Thread.Sleep(2000);
           }
    }
}