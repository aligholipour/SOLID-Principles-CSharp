namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class CalculationCustomerWallet
    {
        private readonly Order _order;
        public CalculationCustomerWallet(Order order)
        {
            _order = order;
        }

        public void CalculateWallet()
        {
            Console.WriteLine($"Calculate wallet {_order.Price}");
        }
    }
}
