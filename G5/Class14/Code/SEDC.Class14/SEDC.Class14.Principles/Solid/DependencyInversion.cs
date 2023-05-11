namespace SEDC.Class14.Principles.Solid
{
    // Bad Example
    public class EmailService
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }
    }

    public class SmsService
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    public class FacebookService
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }
        public void SendFacebookMessage()
        {
            Console.WriteLine("Sending Facebook Message...");
        }
    }

    public class NotificationService
    {
        private EmailService _email;
        private SmsService _sms;
        private FacebookService _facebook;
        public NotificationService()
        {
            _email = new EmailService();
            _sms = new SmsService();
            _facebook = new FacebookService();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
            _facebook.SendFacebookMessage();
        }
    }

    // Dependency Inversion Principle (DIP)
    // Classes should depend on abstractions rather than concrete implementations

    // Abstraction => Some Interface

    // In our case NotificationService is dependent on EmailService, SmsService, FacebookService
    // If you wanted to add a new type of message (ex. WhatsApp message), you would need to modify the NotificationService class.
    // This will potentially introduce breaking changes and violating the Open-Closed Principle(OCP).



    // How can we implement Dependency Inversion Principle?

    // Abstracting the dependencies => Asking for them from outside
    // This helps decouple the high-level and low-level modules, making it easier to change the low-level ones without affecting the high-level ones

    // Low Level Modules => EmailService, SmsService, FacebookService (gets implemented)
    // High Level Module => NotificationService (implements low level modules)

    // Benefits:
    //  - Decoupling or Loose Coupling => Reducing or completely removing dependencies in our code
    //  - Flexibility and Extensibility => By depending on abstractions, new implementations can be introduced without modifying existing code
    //  - Overall with Dependency Inversion Principle, our software will be more adaptable and easier to extend without breaking already working code



    // ** To fully understand Dependency Inversion Principle you need to understand Dependency Injection ** 




    // Continue with the good example here ...



    // Good Example
    public interface IMessageSender
    {
        void SendMessage();
    }

    public class EmailSenderService : IMessageSender
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Sending Email...");
        }
    }

    public class SmsSenderService : IMessageSender
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    public class FacebookMessageSenderService : IMessageSender
    {
        public string FacebookAccount { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Sending Facebook Message...");
        }
    }


    public class NotificationSenderService
    {
        private IMessageSender _messageSender;

        public NotificationSenderService(IMessageSender sender)
        {
            _messageSender = sender;
        }

        public void Send()
        {
            _messageSender.SendMessage();
        }
    }

    public class NotificationSenderMultipleService
    {
        private IList<IMessageSender> _messageSenderList = new List<IMessageSender>();

        public NotificationSenderMultipleService(List<IMessageSender> messageSenders)
        {
            _messageSenderList = messageSenders;
        }

        public void Send()
        {
            foreach (var msgSender in _messageSenderList)
            {
                msgSender.SendMessage();
            }
        }
    }
}
