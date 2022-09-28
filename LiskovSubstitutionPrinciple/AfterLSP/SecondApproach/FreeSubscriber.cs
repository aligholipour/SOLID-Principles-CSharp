namespace LiskovSubstitutionPrinciple.AfterLSP.SecondApproach
{
    public class FreeSubscriber : ICustomerSubscriber, IFreeSubscriber
    {
        public void GetCustomer(int customerId)
        {

        }

        public void AccessToFreeCourse()
        {

        }
    }
}
