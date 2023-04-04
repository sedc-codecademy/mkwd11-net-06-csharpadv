using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Entities
{
    public class User
    {
        public static int UserCount { get; set; } = 0;


        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }

        public User(int id, string name, string lastName)
        {
            Id = id;
            Name = name; 
            LastName = lastName;
            Orders = new List<Order>();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"User: {Name} {LastName}");
        }

        public static void PrintUserCount()
        {
            Console.WriteLine($"There are {UserCount} users in the system.");
        }


    }
}
