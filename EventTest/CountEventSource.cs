using System;

namespace EventTest
{
    public class EventSource{
        public EventHandler<int> Updated;

        public void RaiseUpdated(){
            counter ++;
            // if(Updated != null)
            //     Updated(this, counter);
            Updated?.Invoke(this, counter);
        }

        public int counter;
    }
}