using System;

namespace TestDelegate
{
    public delegate void RaiseEventHandler(string hand);
    public delegate void FallEventHandler();

    public class A
    {
        public event RaiseEventHandler RaiseEvent;
        public event FallEventHandler FallEvent;
        public void Raise(string hand)
        {
            Console.WriteLine("首领A{0}手举杯", hand);
            // 调用举杯事件，传入左或右手作为参数
            if (RaiseEvent != null)
            {
                RaiseEvent(hand);
            }
        }
        /// <summary>
        /// 摔杯
        /// </summary>
        public void Fall()
        {
            Console.WriteLine("首领A摔杯");
            // 调用摔杯事件
            if (FallEvent != null)
            {
                FallEvent();
            }
        }
    }

    /// <summary>
    /// sub B    
    /// </summary>
    public class B{
        private readonly A _a;
        public B(A a){
            _a = a;
            a.RaiseEvent += new RaiseEventHandler(a_RaiseEvent);
            a.FallEvent += new FallEventHandler(a_FallEvent);
        }

        private void a_FallEvent()
        {
            Attack();
        }

        private void a_RaiseEvent(string hand)
        {
            if(hand.Equals("left")){
                Attack();
            }
        }

        private void Attack()
        {
            System.Console.WriteLine("B attack");
        }
    }

    public class C
    {
        private readonly A _a;

        public C(A a){
            _a = a;
            a.RaiseEvent += new RaiseEventHandler(a_RaiseEvent);
            a.FallEvent += new FallEventHandler(a_FallEvent);
        }

        private void a_FallEvent()
        {
            Attack();
        }

        private void a_RaiseEvent(string hand)
        {
            if(hand.Equals("right")){
                Attack();
            }
        }

        private void Attack()
        {
            System.Console.WriteLine("C attack");
        }
    }
}