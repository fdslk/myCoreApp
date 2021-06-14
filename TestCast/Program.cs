using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static TestCast.TestDelegate;

namespace TestCast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Del handle = DelMethod;
            handle("-----------test delegate--------------");
            MethodWithCallBack(1, 1, handle);

            var obj = new TestDelegate();
            Del del1 = obj.DelMethod2;
            Del del2 = obj.DelMethod3;
            Del del3 = DelMethod;

            Del allMethodsDelegate = del1 + del2;
            allMethodsDelegate += del3;

            System.Console.WriteLine(allMethodsDelegate.GetInvocationList().GetLength(0));
            allMethodsDelegate.Invoke("aaa-----");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
