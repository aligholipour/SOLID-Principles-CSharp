namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class OrderValidator
    {
        private readonly Order _order;
        public OrderValidator(Order order)
        {
            _order = order;
        }

        public void Validate()
        {
            Console.WriteLine($"Validate order {_order.OrderNumber}");
        }
    }
}
