using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GmailProvider : NotificationProvider, IMobileMessage
    {
        public override void SendMessage(string toAddress, string subject, string body)
        {
            Console.WriteLine("Validation...");

            Console.WriteLine("Creating Gmail client");

            Console.WriteLine("Sending message using Gmail client");
        }

        public void SendSms(string number, string body)
        {
            throw new NotImplementedException();
        }
    }
}
