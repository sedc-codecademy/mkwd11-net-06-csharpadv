using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_EventsDemo
{
    public class Market
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ProductTypeEnum CurrentPromotion { get; set; }

        public delegate void PromotionSender(ProductTypeEnum promotion);
        public event PromotionSender Promotion;

        public void SubscribeToPromotion(PromotionSender subscribeMethod)
        {
            Promotion += subscribeMethod;
        }

        public void UnSubscribeToPromotion(PromotionSender subscribeMethod)
        {
            Promotion -= subscribeMethod;
        }

        public void AlertForPromotion()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"{Name}, sends new promotion {CurrentPromotion}");

            if(Promotion != null && Promotion.GetInvocationList().Length > 0)
            {
                Promotion(CurrentPromotion);
            } else
            {
                Console.WriteLine("Noone is subscribed");
            }
        }
    }
}
