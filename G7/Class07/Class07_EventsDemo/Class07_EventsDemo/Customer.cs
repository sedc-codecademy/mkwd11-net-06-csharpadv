namespace Class07_EventsDemo
{
    public class Customer
    {
        public string Name { get; set; }
        public string LoyalCardNumber { get; set; }
        public ProductTypeEnum FavoriteProductType { get; set; }

        public void CustomerChecksThePromotion(ProductTypeEnum promotion)
        {
            if(promotion == FavoriteProductType)
            {
                Console.WriteLine($"{Name} - [{promotion}]: Yes this is my favorite product, I will go to the market to buy it.");
            } else
            {
                Console.WriteLine($"{Name} - [{promotion}]: Not for me.");
            }
        }
    }
}
