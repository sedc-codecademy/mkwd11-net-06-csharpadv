using SEDC.Class03.OrderingApp.Domain.Enums;
using SEDC.Class03.OrderingApp.Domain.Models;

namespace SEDC.Class03.OrderingApp.Domain
{
    public static class StaticDatabase
    {
        static StaticDatabase()
        {
            SeedData();
            TextHelper.WriteLineInColor("Database initialized...", ConsoleColor.DarkGreen);
        }

        public static List<User> Users { get; set; } = new List<User>();
        public static List<Order> Orders { get; set; } = new List<Order>();

        public static void ListUsers()
        {
            Users.ForEach(user => Console.WriteLine($"{user.Id}) {user.Username}"));
        }

        private static void SeedData()
        {
            Users = new List<User>()
            {
                new User("Bob123", "Bob St. 100"),
                new User("John321", "John St. 150")
            };

            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProgress),
                new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProgress),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.CouldNotDeliver)
            };

            //Users[0].Orders.Add(Orders[0]);
            //Users[0].Orders.Add(Orders[1]);
            //Users[0].Orders.Add(Orders[2]);
            //Users[1].Orders.Add(Orders[3]);
            //Users[1].Orders.Add(Orders[4]);

            // OR

            Users[0].Orders.AddRange(Orders.Take(3));
            Users[1].Orders.AddRange(Orders.TakeLast(2));
        }
    }
}
