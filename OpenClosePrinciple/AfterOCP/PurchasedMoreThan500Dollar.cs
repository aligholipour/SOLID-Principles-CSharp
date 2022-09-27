using OpenClosePrinciple.AfterOCP;

namespace OpenClosePrinciple.WithOCP
{
    public class PurchasedMoreThan500Dollar : BaseDiscountCalculator
    {
        public override decimal CalculateDiscount(decimal orderAmount) =>
            orderAmount * 15 / 100;
    }
}
