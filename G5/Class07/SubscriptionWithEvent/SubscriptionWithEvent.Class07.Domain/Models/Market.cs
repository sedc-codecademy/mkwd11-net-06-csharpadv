using SubscriptionWithEvent.Class07.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionWithEvent.Class07.Domain.Models
{
    // This is a publisher class
    // This class sends messages to all objects that subscribe for getting such messages
    // In our case, its a Market and it sends promotion materials to anyone that subscried for those
    // Users can also unsubscribe so they wont get any promotions in the future
    // The email is required for marketing purposes for the Market
    // Reason is required for unsubscribing so that the market knows why people are unsubscribing
    public class Market
    {
        // Delegates are like a type of method that is allowed to be subscribed for some event 
        // All methods that has that signature can be allowed as subscribers on the event
        public delegate void PromotionSender(ProductType productType);
        public delegate void InformationSender(string info);

        // These are the events and they keep track of who is subscribed to listen to some message when it is sent
        // The events use delegates to only accept methods of that delegate signature
        public event PromotionSender Promotions;
        public event InformationSender Information;

        // Standard properties
        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> Complaints { get; set; } = new List<string>();
        public List<string> Email { get; set; } = new List<string>();

        // Standard constructor
        public Market() { }

        // A method that does some work
        // Thread.Sleep(3000) simulates that something is being done for 3 seconds
        public void SendPromotion()
        {
            Console.WriteLine($"{Name} is sending promotion for {CurrentPromotion}");
            Console.WriteLine("...Sending....");
            Thread.Sleep(3000);
            Send();
        }

        // The event is executed here, informing all the methods that subscribed with some value ( currentPromotion in our case )
        private void Send()
        {
            Promotions(CurrentPromotion);
        }

        // A method that accepts a subscriber method that must follow the PromotionSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get a promotion each time the market sends one
        public void SubcriptionForPromotion(PromotionSender sender, string email)
        {
            Promotions += sender;
            Email.Add(email);
        }
        // A method that accepts a subscriber method that must follow the InformationSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get only relevant information each time the market sends one
        // This is used just as an example that we can have multiple events with different delegates for different business logic
        public void SubcriptionForInformation(InformationSender subcription, string email)
        {
            Information += subcription;
            Email.Add(email);
        }
        // A method that removes a subscriber method from the Promotions event 
        // It also requires a reason so it can be saved in ZalbiIPoplaki as feedback
        // This subscriber expects to not get any promotions when the market sends some in the future
        public void UnSubcriptionForPromotion(PromotionSender unSubcription, string complaints)
        {
            Promotions -= unSubcription;
            Complaints.Add(complaints);
        }
        // A method that removes a subscriber method from the Information event 
        // It also requires a reason so it can be saved in ZalbiIPoplaki as feedback
        public void UnSubcriptionForInformation(InformationSender unSubcription, string complaints)
        {
            Information -= unSubcription;
            Complaints.Add(complaints);
        }

        // A method read all complaints 
        public void ReadComplaints()
        {
            Console.WriteLine("Read a Complaints:");
            foreach (string complaints in Complaints)
            {
                Console.WriteLine(complaints);
            }
        }


    }
}
