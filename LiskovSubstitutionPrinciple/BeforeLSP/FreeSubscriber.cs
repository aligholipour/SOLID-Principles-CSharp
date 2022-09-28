namespace LiskovSubstitutionPrinciple.BeforeLSP
{
    public class FreeSubscriber : BaseSubscriber
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
