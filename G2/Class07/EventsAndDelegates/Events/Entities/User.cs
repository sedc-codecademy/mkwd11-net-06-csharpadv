namespace Events.Entities
{
    public class User
    {
        public string Name { get; set; }

        public ProductType FavoriteProductType { get; set; }

        public void ReactOnPromotion(ProductType productType)
        {
            if (productType == FavoriteProductType)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name}: Yaaaas it's my favorite.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name}: I hate this {productType}.");
                Console.ResetColor();
            }
        }
    }
}
