namespace LiskovSubstitutionPrinciple.BeforeLSP
{
    public class PermiumSubscriber : BaseSubscriber
    {
        public override void AccessToFreeCource()
        {
            base.AccessToFreeCource();
        }

        public override void AccessToPermiumCourse()
        {
            base.AccessToPermiumCourse();
        }
    }
}
