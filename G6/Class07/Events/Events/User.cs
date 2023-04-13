using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //subscriber class
    public class User
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public ProductType FavouriteProductType { get; set; }

        //subscription method, will get executed when certain product is on promotion
        public void ReactOnPromotion(ProductType productType)
        {
            if(productType == FavouriteProductType)
            {
                Console.WriteLine($"{FirstName}: My favourite product is on promotion");
            }
            else
            {
                Console.WriteLine($"{FirstName} must wait. {FavouriteProductType.ToString()} is not on promotion");
            }
        }
    }
}
