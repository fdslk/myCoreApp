using System;

namespace EventTest
{
    public class CounterWithData{
        private int threshold;
        private int total;

        public CounterWithData(int passedThreshold){
            this.threshold = passedThreshold;
        }

        public void Add(int a){
            total += a;
            if(total >= this.threshold){
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.TimeReached = DateTime.Now;
                args.Threshold = this.threshold;
                OnThresholdReached(args);
            }
        }

        private void OnThresholdReached(ThresholdReachedEventArgs args)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if(handler != null){
                handler(this, args);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }   
}