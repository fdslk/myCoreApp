using System;

namespace EventTest
{
    public class CounterWithDelegate{
        
        public delegate void ThresholdReachedHandlerEvent(Object sender, ThresholdReachedEventArgs e);
        private int threshold;
        private int total;

        public CounterWithDelegate(int passedThreshold){
            this.threshold = passedThreshold;
        }

        public void Add(int a){
            total += a;
            if(total >= threshold){
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        public event ThresholdReachedHandlerEvent ThresholdReached;

        private void OnThresholdReached(ThresholdReachedEventArgs args)
        {
            ThresholdReachedHandlerEvent handler = ThresholdReached;
            if(handler != null){
                handler(this, args);
            }
        }
    }
}