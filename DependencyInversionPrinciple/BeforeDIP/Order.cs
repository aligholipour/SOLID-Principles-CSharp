namespace DependencyInversionPrinciple.BeforeDIP
{
    public class Order
    {
        private readonly string _message;
        private readonly NotificationType _notificationType;
        private SendEmail _sendEmail;
        private SendSms _sendSms;
        public Order(string message, NotificationType notificationType)
        {
            _message = message;
            _notificationType = notificationType;
        }

        public void SetOrder()
        {
            if (_notificationType == NotificationType.Email)
            {
                _sendEmail = new SendEmail();
               _sendEmail.Send(_message);
            }
            else
            {
                _sendSms = new SendSms();
                _sendSms.Send(_message);
            }
        }
    }
}
