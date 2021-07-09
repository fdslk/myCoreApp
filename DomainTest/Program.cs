using System;

namespace DomainTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            var order = new Order(OrderService.ORDER_STATUS_CANCELED, Guid.NewGuid().ToString());
            System.Console.WriteLine(orderService.cancel(order));

            var orderFull = new OrderFull() { Status = OrderFull.STATUS_SUBMIT, OrderId = Guid.NewGuid().ToString() };
            System.Console.WriteLine(orderFull.canCancel());
        }
    }
}
