﻿using System;

namespace EventTest
{
    class Program
    {
        public static readonly int v = new Random().Next(10);

        static void Main(string[] args)
        {
            EventImplementation1();
        }



        private static void EventImplementation1()
        {
            System.Console.WriteLine(string.Format("random number is {0}", v));
            var c = new CounterWithDelegate(v);
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        private static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold,  e.TimeReached);
            Environment.Exit(0);
        }
    }
}
