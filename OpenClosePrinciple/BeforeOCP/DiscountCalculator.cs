namespace OpenClosePrinciple.BeforeOCP
{
    public class DiscountCalculator
    {
        private readonly decimal _orderAmount;
        public DiscountCalculator(decimal orderAmount)
        {
            _orderAmount = orderAmount;
        }

        public decimal CalculateTotalDiscount()
        {
            if (_orderAmount >= 100)
            {
                return _orderAmount * 10 / 100;
            }
            else if (_orderAmount >= 500)
            {
                return _orderAmount * 15 / 100;
            }
            else if (_orderAmount >= 1000)
            {
                return _orderAmount * 20 / 100;
            }
            else
            {
                return _orderAmount;
            }
        }
    }
}
