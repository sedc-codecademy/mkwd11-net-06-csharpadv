namespace Class07_EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { 
                Name = "Risto",
                LoyalCardNumber = "123",
                FavoriteProductType = ProductTypeEnum.Meat
            };

            Customer c2 = new Customer
            {
                Name = "Tijana",
                LoyalCardNumber = "133",
                FavoriteProductType = ProductTypeEnum.Fruit
            };

            Customer c3= new Customer
            {
                Name = "Frosina",
                LoyalCardNumber = "124",
                FavoriteProductType = ProductTypeEnum.Cheese
            };

            Market market = new Market
            {
                Name = "Lidl",
                Address = "/",
                CurrentPromotion = ProductTypeEnum.Drinks
            };

            market.AlertForPromotion();

            market.SubscribeToPromotion(c1.CustomerChecksThePromotion);
            market.AlertForPromotion();

            market.SubscribeToPromotion(c2.CustomerChecksThePromotion);
            market.AlertForPromotion();

            market.CurrentPromotion = ProductTypeEnum.Fruit;
            market.AlertForPromotion();

            market.SubscribeToPromotion(c3.CustomerChecksThePromotion);
            market.UnSubscribeToPromotion(c1.CustomerChecksThePromotion);
            market.CurrentPromotion = ProductTypeEnum.Cheese;
            market.AlertForPromotion();
        }
    }
}