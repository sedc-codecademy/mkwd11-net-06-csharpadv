namespace Domain
{
    public interface INotificationProvider
    {
        //Classes that will implement this interface will be forced to implement the methods that are defined as rules inside this interface
        void SendMessage(string toAddress, string subject, string body);
    }
}
