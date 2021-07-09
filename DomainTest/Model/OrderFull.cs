namespace DomainTest
{
    /* Rich Domain Model */
    public class OrderFull
    {
        public static readonly int STATUS_SUBMIT = 1;
        public static readonly int STATUS_CANCELED = 2;

        private int status;
        private string orderId;

        public int Status { get => status; set => status = value; }
        public string OrderId { get => orderId; set => orderId = value; }

        //取消订单
        public bool cancel()
        {
            if (!canCancel())
            {
                return false;
            }
            this.status = STATUS_CANCELED;
            return true;
        }
        //是否可以取消
        public bool canCancel()
        {
            return STATUS_SUBMIT.Equals(this.status);
        }
    }
}