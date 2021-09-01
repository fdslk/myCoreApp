using System;
using AbstractFactoryDesignPatternInCSharp;

namespace MainFunc
{
    static class Program
    {
        static void Main(string[] args)
        {
            IMobilePhone nokiaMobilePhone = new Nokia();  
            MobileFactory nokiaClient = new MobileFactory(nokiaMobilePhone);  
  
            Console.WriteLine("********* NOKIA **********");  
            Console.WriteLine(nokiaClient.GetNormalPhoneDetail());  
            Console.WriteLine(nokiaClient.GetSamrtPhoneDetail());  
              
            IMobilePhone samsungMobilePhone = new Samsung();  
            MobileFactory samsungClient = new MobileFactory(samsungMobilePhone);  
  
            Console.WriteLine("******* SAMSUNG **********");  
            Console.WriteLine(samsungClient.GetNormalPhoneDetail());  
            Console.WriteLine(samsungClient.GetSamrtPhoneDetail());  
            
            // IMobilePhone appleMobilePhone = new Apple();  
            // MobileFactory AppleClient = new MobileFactory(appleMobilePhone);  
            //
            // Console.WriteLine("******* SAMSUNG **********");  
            // Console.WriteLine(samsungClient.GetNormalPhoneDetail());  
            // Console.WriteLine(samsungClient.GetSamrtPhoneDetail());  
  
            Console.ReadKey();          
        }
    }
}
