
using Events;

User user = new User
{
    FirstName = "Bob",
    Age = 28,
    FavouriteProductType = ProductType.Fruit
};

User secondUser = new User
{
    FirstName = "Ana",
    Age = 23,
    FavouriteProductType = ProductType.Meat
};

Market market = new Market()
{
    Name = "Super Market",
    Address = "Address 1",
    CurrentPromotion = ProductType.Meat,
};

market.SubscribeForPromotion(user.ReactOnPromotion);
market.SubscribeForPromotion(secondUser.ReactOnPromotion);

market.SendPromotionInfo();

//we remove ReactOnPromotion from secondUser from subscribers of the event
market.UnSubscribeForPromotion(secondUser.ReactOnPromotion);

market.SendPromotionInfo();

