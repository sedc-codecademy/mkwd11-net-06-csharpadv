using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Entities
{
    // This is a publisher class
    public class Market
    {
        // Delegates are like a type of method that is allowed to be subscribed for some event 
        public delegate void PromotionSender(ProductType product);

        // Event
        public event PromotionSender Promotions;

        // Standard properties 
        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> ZalbiIPoplaki { get; set; }
        public List<string> Emails { get; set; }

        // Standard constructor that instantiates lists
        public Market()
        {
            ZalbiIPoplaki = new List<string>();
            Emails = new List<string>();
        }

        public void SubscribeForPromotion(PromotionSender subscriber, string email) 
        {
            Promotions += subscriber;
            Emails.Add(email);
        }

        public void UnsubscribeForPromotion(PromotionSender unsubcriber, string reason) 
        {
            Promotions -= unsubcriber;
            ZalbiIPoplaki.Add(reason);
        }

        public void SendPromotion() 
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{Name} is sending promotion for {CurrentPromotion}");
            Console.WriteLine("...Sending");
            Thread.Sleep(3000);
            Send();
        }

        private void Send() 
        {
            Promotions(CurrentPromotion);
        }
    }
}
