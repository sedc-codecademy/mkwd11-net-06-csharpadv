using SEDC.Class03.StaticDbDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.StaticDbDemo.InMemoryDb
{
    public static class StaticDb
    {
        public static int UserId { get; set; } = 4;
        public static int OrderId { get; set; } = 3;

        //static StaticDb()
        //{
        //    UserId = 4;
        //    OrderId = 3;
        //}


        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "Stojadin",
                Orders = new List<Order>()
            },
            new User()
            {
                Id = 2,
                Name = "Martin",
                Orders = new List<Order>()
            },
            new User()
            {
                Id = 3,
                Name = "Antonio",
                Orders = new List<Order>()
            },
            new User()
            {
                Id = 4,
                Name = "Petko",
                Orders = new List<Order>()
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                DateCreated = DateTime.Now,
                Status = "Pending"
            },
            new Order()
            {
                Id = 2,
                DateCreated = DateTime.Now.AddDays(-5),
                Status = "In progress"
            },
            new Order()
            {
                Id = 3,
                DateCreated = DateTime.Now.AddDays(-10),
                Status = "Delivered"
            }
        };

        public static void AddNewUser(User user)
        {
            Users.Add(user);
            }

        public static void AddNewOrder(Order order)
        {
            Orders.Add(order);
        }

        public static void PrintAllUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Id} {user.Name}");
            }
        }

        public static void PrintAllOrders()
        {
            foreach (var order in Orders)
            {
                Console.WriteLine($"{order.Id} - {order.DateCreated.ToShortDateString()} | Status: {order.Status}");
            }
        }
    }
}
