namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class OrderSaver
    {
        private readonly Order _order;
        public OrderSaver(Order order)
        {
            _order = order;
        }

        public void Save()
        {
            Console.WriteLine($"Save order {_order.OrderNumber}");
        }
    }
}
