namespace SingleResponsibilityPrinciple.BeforeSRP
{
    public class OrderProcessor
    {
        private readonly Order _order;
        public OrderProcessor(Order order)
        {
            _order = order;
        }

        public void Validate()
        {
            //Validate order
            Console.WriteLine($"Validate order {_order.OrderNumber}");
        }

        public void Notify()
        {
            //Send notification
            Console.WriteLine($"Send notification {_order.OrderNumber}");
        }

        public void Save()
        {
            //Save order
            Console.WriteLine($"Save order {_order.OrderNumber}");
        }

        public void CalculaitonCustomerWallet()
        {
            //Calculate customer wallet
            Console.WriteLine($"Calculate wallet {_order.Price}");
        }
    }
}
