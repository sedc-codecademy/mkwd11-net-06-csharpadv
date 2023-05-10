namespace Principles.Principles
{
    // Bad Example
    public class EmailMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            // ... Code that sends an Email
        }
    }

    public class SmsMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            // ... Code that sends an SMS
        }
    }
    public class FacebookMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendFacebook()
        {
            // ... Code that sends a Facebook Message
        }
    }
    public class Notification
    {
        private EmailMessage _email;
        private SmsMessage _sms;
        private FacebookMessage _facebook;
        public Notification()
        {
            _email = new EmailMessage();
            _sms = new SmsMessage();
            _facebook = new FacebookMessage();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
            _facebook.SendFacebook();
        }
    }

    // Good Example
    public interface IMessage
    {
        void SendMessage();
    }

    public class Email : IMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            // ... Code that sends an Email
        }
    }

    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            // ... Code that sends an SMS
        }
    }
    public class Facebook : IMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            // ... Code that sends a Facebook Message
        }
    }
    public class NotificationGood
    {
        private List<IMessage> _messages;

        public NotificationGood(List<IMessage> messages)
        {
            _messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
