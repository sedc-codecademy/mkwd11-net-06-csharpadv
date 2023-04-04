namespace Domain
{
    //Abstract or standard parent class can implement some interface which will chain the rule down to its childs
    public abstract class NotificationProvider : INotificationProvider
    {
        public string Name { get; set; }

        public virtual void SendMessage(string toAddress, string subject, string body)
        {
            Console.WriteLine("Base implementation");
        }
    }
}
