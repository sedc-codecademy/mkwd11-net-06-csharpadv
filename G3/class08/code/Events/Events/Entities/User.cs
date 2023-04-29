using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Entities
{
    // This class is a subscriber class
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavoriteType { get; set; }

        // A method that can read a promotion and get excited if that is the favorite type of this person
        public void ReadPromotion(ProductType product) 
        {
            Console.WriteLine($"Mr/Ms: {Name}, The product {product} is on sale");
            if (product == FavoriteType) 
            {
                Console.WriteLine("MY FAVORITE!");
            }
        }
    }
}
