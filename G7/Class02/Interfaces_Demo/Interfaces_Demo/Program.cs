using Domain;

namespace Interfaces_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App logic...");

            INotificationProvider provider = new YahooProvider();

            provider.SendMessage("risto@gmail.com", "Subject", "Body....");
        }
    }
}