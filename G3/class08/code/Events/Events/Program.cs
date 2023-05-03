using Events.Entities;

Market Vero = new Market()
{
    Name = "Vero",
    CurrentPromotion = ProductType.Food
};
Market Tinex = new Market()
{
    Name = "Tinex",
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

// Users subscribe to Vero for their promotions
Vero.SubscribeForPromotion(Bob.ReadPromotion, "bob@gmail.com");
Vero.SubscribeForPromotion(Jill.ReadPromotion, "jill@gmail.com");
Vero.SubscribeForPromotion(Greg.ReadPromotion, "greg@gmail.com");

Vero.SendPromotion();

Vero.CurrentPromotion = ProductType.Cosmetics;

Vero.UnsubscribeForPromotion(Bob.ReadPromotion, "Spam");

Vero.SendPromotion();