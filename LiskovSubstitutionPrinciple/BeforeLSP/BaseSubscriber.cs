namespace LiskovSubstitutionPrinciple.BeforeLSP
{
    public class BaseSubscriber
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public virtual void AccessToFreeCource()
        {

        }
        public virtual void AccessToPermiumCourse()
        {

        }
    }
}
