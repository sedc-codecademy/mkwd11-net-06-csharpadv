using Events.Entities;

User user1 = new User()
{
    Name = "Ilija",
    FavoriteProductType = ProductType.Meat
};

User user2 = new User()
{
    Name = "Elena",
    FavoriteProductType = ProductType.Fruit
};

User user3 = new User()
{
    Name = "Slave",
    FavoriteProductType = ProductType.Cosmetics
};

Market market = new Market()
{
    Name = "Market",
    ProductOnPromotion = ProductType.Fruit
};

market.Subscribe(user1.ReactOnPromotion);
market.Subscribe(user2.ReactOnPromotion);
market.Subscribe(user3.ReactOnPromotion);
market.SendPromotionInfo();

market.Unsubscribe(user1.ReactOnPromotion);
market.SendPromotionInfo();