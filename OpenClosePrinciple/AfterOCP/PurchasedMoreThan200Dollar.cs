using OpenClosePrinciple.AfterOCP;

namespace OpenClosePrinciple.WithOCP
{
    public class PurchasedMoreThan200Dollar : BaseDiscountCalculator
    {
        public override decimal CalculateDiscount(decimal orderAmount) =>
            orderAmount * 10 / 100;
    }
}
