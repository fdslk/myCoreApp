namespace DomainTest
{
    public class OrderService
    {
        public static readonly int ORDER_STATUS_SUBMIT = 1;
        public static readonly int ORDER_STATUS_CANCELED = 2;
        //取消订单
        public bool cancel(Order order)
        {
            if (!canCancel(order))
            {
                return false;
            }
            order.Status = ORDER_STATUS_CANCELED;
            //可能有其他操作。。。
            return true;
        }
        //判断是否可以取消
        public bool canCancel(Order order)
        {
            return ORDER_STATUS_SUBMIT.Equals(order.Status);
        }
    }
}