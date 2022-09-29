namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class OrderProcessor
    {
        private readonly OrderValidator _orderValidator;
        private readonly OrderNotifier _orderNotifier;
        private readonly OrderSaver _orderSaver;
        private readonly CalculationCustomerWallet _calculationCustomerWallet;
        public OrderProcessor(
            OrderValidator orderValidator, 
            OrderNotifier orderNotifier, 
            OrderSaver orderSaver, 
            CalculationCustomerWallet calculationCustomerWallet)
        {
            _orderValidator = orderValidator;
            _orderNotifier = orderNotifier;
            _orderSaver = orderSaver;
            _calculationCustomerWallet = calculationCustomerWallet;
        }

        public void Process()
        {
            _orderValidator.Validate();
            _orderSaver.Save();
            _orderNotifier.Nofiy();
            _calculationCustomerWallet.CalculateWallet();
        }
    }
}
