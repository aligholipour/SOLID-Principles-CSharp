namespace DependencyInversionPrinciple.AfterDIP
{
    public interface INotificationService
    {
        void SendEmail(string message);
        void SendSms(string message);
    }
}
