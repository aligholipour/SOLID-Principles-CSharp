namespace LiskovSubstitutionPrinciple.AfterLSP.SecondApproach
{
    public class PermiumSubscriber : ICustomerSubscriber, IPermiumSubscriber
    {
        public void GetCustomer(int customerId)
        {

        }

        public void AccessToPermiumCourse()
        {

        }
    }
}
