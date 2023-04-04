namespace Domain
{
    public class YahooProvider : INotificationProvider
    {
        public void SendMessage(string toAddress, string subject, string body)
        {
            Console.WriteLine("Validation...");

            Console.WriteLine("Creating Yahoo client");

            Console.WriteLine("Sending message using Yahoo client");
        }
    }
}