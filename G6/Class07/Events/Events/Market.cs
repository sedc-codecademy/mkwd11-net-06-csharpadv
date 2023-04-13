using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //publisher class
    //sends information for promotions
    public class Market
    {
        //Standard properties
        public string Name { get; set; }
        public string Address { get; set; }
        public ProductType CurrentPromotion { get; set; }

        //in a publisher class we must have a delegate that defines the signature of the subscription methods (see User class, method ReactOnPromotion)
        public delegate void PromotionSender(ProductType productType);
        //this represents an event
        //to this event, only methods that follow the signature of the PromotionSender delegate, can subscribe
        //when this event happens, those methods will get executed
        public event PromotionSender Promotion;

        //we must have a method that will subscribe other methods to our event
        public void SubscribeForPromotion(PromotionSender promotion)
        {
            Promotion += promotion;
        }

        public void UnSubscribeForPromotion(PromotionSender promotion)
        {
            Promotion -= promotion;
        }

        public void SendPromotionInfo()
        {
            Console.WriteLine("================");
            Console.WriteLine($"{Name} market is sending promotion onfo for {CurrentPromotion.ToString()}");

            Promotion(CurrentPromotion);
        }
    }
}
