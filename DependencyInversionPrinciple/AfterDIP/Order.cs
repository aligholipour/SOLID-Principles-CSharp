namespace DependencyInversionPrinciple.AfterDIP
{
    public class Order
    {
        private readonly string _message;
        private readonly INotificationService _notificationService;
        private readonly NotificationType _notificationType;
        public Order(string message, INotificationService notificationService, NotificationType notificationType)
        {
            _message = message;
            _notificationService = notificationService;
            _notificationType = notificationType;
        }

        public void SetOrder()
        {
            if (_notificationType == NotificationType.Email)
                _notificationService.SendEmail(_message);
            else
                _notificationService.SendSms(_message);
        }
    }
}
