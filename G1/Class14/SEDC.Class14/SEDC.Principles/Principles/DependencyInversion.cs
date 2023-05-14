namespace SEDC.Principles.Principles
{

    public class EmailMessage
    {
        public string EmailAddressTo { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            // send mail
        }
    }


    public class SmsMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSms()
        {
            // send sms
        }
    }

    public class FacebookMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendFacebookMessage()
        {

        }
    }



    public class Notification
    {
        private EmailMessage _emailMessage;
        private SmsMessage _smsMessage;
        private FacebookMessage _facebookMessage;

        public Notification()
        {
            _emailMessage = new EmailMessage();
            _smsMessage = new SmsMessage();
            _facebookMessage = new FacebookMessage();
        }


        public void Send()
        {
            _emailMessage.SendEmail();
            _smsMessage.SendSms();
            _facebookMessage.SendFacebookMessage();
        }
    }



    //Good example

    public interface IMessage
    {
        void SendMessage();
    }


    public class Email : IMessage 
    {
        public string EmailAddressTo { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }


    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }

    public class Facebook : IMessage
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }

    public class FacebookNew : IMessage
    {
        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }


    public class NotificationGood
    {
        private ICollection<IMessage> _messages;

        public NotificationGood(ICollection<IMessage> messages)
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
