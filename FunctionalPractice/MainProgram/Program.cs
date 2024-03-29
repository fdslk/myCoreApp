﻿using System;
using System.Linq;

namespace MainProgram
{
    class Program
    {
        delegate double MyFunction(double x);
        static void Main(string[] args)
        {
            // MyFunction f = Math.Sin;
            // double y = f(4); //y=sin(4)
            // f = Math.Exp;
            // y = f(4);    
            // System.Console.WriteLine(y.ToString("00.00"));
            
            // Func<double, double> f = Math.Sin;
            // double y = f(4); //y=sin(4)
            // f = Math.Exp;
            // y = f(4);        //y=exp(4)

            // Predicate<string> isEmptyString = String.IsNullOrEmpty; // return type is bool

            // Func<string, bool> isEmptyString2 = String.IsNullOrEmpty;// return type can be defined

            // Action<string> print = Console.WriteLine;// no return


            // Func<double, double> f1 = Math.Sin;
            // Func<double, double> f2 = Math.Exp;
            // Func<decimal, decimal> f3 = Math.Abs;
            // double y1 = f1(4) + f2(5) + ((double)f3(3)); //y=sin(3) + exp(5)
            // f2 = f1;
            // y1 = f2(9);                //y=sin(9) 

            // // costume function
            // Func<double, double> f5 = delegate(double x) { return 3*x+1; };
            // double y2 = f5(4); //y=13
            // f = (x) => 3*x+1;
            // y = f(5);        //y=16      
            Action<string> action = Console.WriteLine;
            Action<string> hello = Hello;
            Action<string> goodbye = Goodbye;
            action += Hello;
            action += (x) => { Console.WriteLine("  Greating {0} from lambda expression", x); };
            action("First");  // called WriteLine, Hello, and lambda expression

            action -= hello;
            action("Second"); // called WriteLine, and lambda expression

            action = Console.WriteLine + goodbye
                    + delegate(string x){ 
                                        Console.WriteLine("  Greating {0} from delegate", x); 
                    };
            action("Third");  // called WriteLine, Goodbye, and delegate

            (action - Goodbye)("Fourth"); // called WriteLine and delegate 

            action.GetInvocationList().ToList().ForEach(del => Console.WriteLine(del.Method.Name));
        }

        static void Hello(string s)
        {
            System.Console.WriteLine("  Hello, {0}!", s);
        }

        static void Goodbye(string s)
        {
            System.Console.WriteLine("  Goodbye, {0}!", s);
        }
    }
}
