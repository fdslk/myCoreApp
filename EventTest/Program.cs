using System;

namespace EventTest
{
    class Program
    {
        public static readonly int v = new Random().Next(10);
        public static readonly int clickMark = 5;

        static void Main(string[] args)
        {
            // EventImplementation1();
            // ClickEvent();
            subscribeUpdateSource();
        }


        public static void subscribeUpdateSource(){
            var eventSource = new EventSource();
            eventSource.Updated += UpdateReached;
            eventSource.RaiseUpdated();
            eventSource.RaiseUpdated();
            System.Console.WriteLine(eventSource.counter);
        }

        private static void UpdateReached(object sender, int e)
        {
            System.Console.WriteLine("Update source Event reached");
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

        public static void ClickEvent(){
            bool isClick = false;
            WinformDelegate winformDelegate = new WinformDelegate();
            winformDelegate.ClickHandler += ClickedEvent;
            while(!isClick){
                int clickFlag = new Random().Next(10);
                System.Console.WriteLine("Is not click, {0}", clickFlag);
                if(clickFlag > clickMark){
                    winformDelegate.ClickEvent(clickFlag > clickMark);
                }
            }
        }

        private static void ClickedEvent(object sender, EventArgs e)
        {
            System.Console.WriteLine("the button is clicked.");
            Environment.Exit(0);
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
