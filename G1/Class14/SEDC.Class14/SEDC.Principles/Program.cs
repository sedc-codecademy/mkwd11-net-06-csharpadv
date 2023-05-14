

using SEDC.Principles.Principles;

AppBadExample.Run();
AppGoodExample.Run();



Email email = new Email()
{
    EmailAddressTo = "martin@gmail.com",
    Subject = "Homework",
    Content = "Hello there this is my homework"
};


Sms sms = new Sms() { Message = "Hello there this is my homework", PhoneNumber = "070222333" };

NotificationGood notification = new NotificationGood(new List<IMessage> { email, sms});

notification.Send();