namespace DomainTest
{
    /* 
    Anemic Domain Model
     */
    public class Order
    {
        private int status;
        private string orderId;

        public Order(int status, string orderId)
        {
            this.Status = status;
            this.OrderId = orderId;
        }

        public int Status { get => status; set => status = value; }
        public string OrderId { get => orderId; set => orderId = value; }
    }
}