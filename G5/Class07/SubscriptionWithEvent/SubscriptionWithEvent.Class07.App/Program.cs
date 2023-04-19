using SubscriptionWithEvent.Class07.Domain.Enums;
using SubscriptionWithEvent.Class07.Domain.Models;

Market KamMarket = new Market()
{
    Name = "KamMarket",
    CurrentPromotion = ProductType.Food
};
Market VeroMarket = new Market()
{
    Name = "VeroMarket",
    CurrentPromotion = ProductType.Electronics
};
User Bob = new User()
{
    Name = "Bob Bobsky",
    Age = 21,
    FavoriteType = ProductType.Food
};
User Jill = new User()
{
    Name = "Jill Wayne",
    Age = 28,
    FavoriteType = ProductType.Cosmetics
};
User Greg = new User()
{
    Name = "Greg Gregsky",
    Age = 48,
    FavoriteType = ProductType.Electronics
};

// Users subscribe to KamMarket for their promotions
KamMarket.SubcriptionForPromotion(Bob.ReadPromotion, "bob@gmail.com");
KamMarket.SubcriptionForPromotion(Jill.ReadPromotion, "jill@gmail.com");
KamMarket.SubcriptionForPromotion(Greg.ReadPromotion, "greg@gmail.com");

// Users subscribe to VeroMarket for their promotion
VeroMarket.SubcriptionForPromotion(Bob.ReadPromotion, "bob@gmail.com");
VeroMarket.SubcriptionForPromotion(Greg.ReadPromotion, "greg@gmail.com");

Console.WriteLine("======= KAM MARKET ============");
KamMarket.SendPromotion(); // This will send promotions to everyone who subscribed ( Will call the methods that were sent to the event )

Console.WriteLine("======= VERO MARKET ============");
VeroMarket.SendPromotion(); // VeroMarket decides to send promotions as well to everyone who subscribed

KamMarket.CurrentPromotion = ProductType.Cosmetics; // The promotion is changed 
KamMarket.UnSubcriptionForPromotion(Greg.ReadPromotion, "Boring");// Greg is not happy with KamMarket new promotions


VeroMarket.UnSubcriptionForPromotion(Greg.ReadPromotion, "Nothing great going on in the promotions!"); // Greg is not happy with VeroMarket promotions

Console.WriteLine("======= KAM MARKET ============");
KamMarket.SendPromotion();// KamMarket sends another promotion

Console.WriteLine("======= Read Complaints ============");
KamMarket.ReadComplaints(); // KamMarket now reads the Complaints
VeroMarket.ReadComplaints(); // VeroMarket now reads the Complaints