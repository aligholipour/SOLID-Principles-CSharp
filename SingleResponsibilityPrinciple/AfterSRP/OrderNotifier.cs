namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class OrderNotifier
    {
        private readonly Order _order;
        public OrderNotifier(Order order)
        {
            _order = order;
        }

        public void Nofiy()
        {
            Console.WriteLine($"Send notification {_order.OrderNumber}");
        }
    }
}
