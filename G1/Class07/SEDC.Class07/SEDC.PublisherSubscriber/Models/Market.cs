using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PublisherSubscriber.Models
{
    public class Market
    {
        public delegate void PromotionSender(ProductType productType, string name);
        event PromotionSender PromotionSenderEvent;



        public string Name { get; set; }
        public List<string> Emails { get; set; }
        public ProductType CurrentProductType { get; set; }

        public Market()
        {
            Emails = new List<string>();
        }


        public void SubscribeToPromotion(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent += eventHandler;
            Emails.Add(email);
        }

        public void Unsubscribe(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent -= eventHandler;
            string emailToDelete = Emails.FirstOrDefault(x => x == email);
            if (emailToDelete != null)
                Emails.Remove(email);
        }

        public void Send()
        {
            PromotionSenderEvent(CurrentProductType, Name);
        }
    }

    public enum ProductType
    {
        Food,
        Cosmetics,
        Electronic,
        Other
    }
}
