using System;

namespace EventHandle
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var thresholdList = new ThresholdList();
            thresholdList.thresholdreached += EventPrc.ThresholdReachedDealProcess.ThresholdReachedDeal;

            var i = 0;
            var random = new Random();
            while (i < 10)
            {
                thresholdList.AddElement($"John {i}", random.Next(80, 120));
                i++;
            }
        }
    }
}