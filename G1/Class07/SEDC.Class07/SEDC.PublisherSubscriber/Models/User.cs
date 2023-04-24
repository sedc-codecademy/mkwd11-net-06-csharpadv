using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PublisherSubscriber.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public User(string fName, string lName, int age, string email)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Email = email;
        }

        public void ReadPromotion(ProductType productType, string marketName)
        {
            Console.WriteLine($"Hello {FirstName}, there is a promotion available for {productType} at {marketName}");
        }


    }
}
