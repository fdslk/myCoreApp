using System;

namespace EventHandle
{
    public class EventPrc
    {
        public static class ThresholdReachedDealProcess
        {
            // define delegate is to define a teamplate
            public static void ThresholdReachedDeal(Object sender, ThresholdReachedEventArgs e)
            {
                Console.WriteLine("The threshold {0} was reached.", e.Threshod);
                Environment.Exit(0);
            }
        }
    }
}