using System;
using System.Collections.Generic;

namespace EventHandle
{
    public class ThresholdList
    {
        private const int MAX_NUMBER = 3;
        
        private Dictionary<String, Double> dict = new Dictionary<string, double>();

        public event EventHandler<ThresholdReachedEventArgs> thresholdreached;

        public void AddElement(string name, double score)
        {
            dict.Add(name, score);
            if (dict.Count >= MAX_NUMBER)
            {
                var thresholdReachedEventArgs = new ThresholdReachedEventArgs {Threshod = MAX_NUMBER};
                OnThresholdReached(thresholdReachedEventArgs);
            }
        }

        private void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            var thresholdReachedEvent = thresholdreached;
            thresholdReachedEvent?.Invoke(this, e);// trigger event
        }
    }
}