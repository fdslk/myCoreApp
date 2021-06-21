using System;

namespace EventTest
{
    public class Counter{

        private int threshold;
        private int total;

        public Counter(int passedThreshold){
            threshold = passedThreshold;
        }
        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler ThresholdReached;
    }
}