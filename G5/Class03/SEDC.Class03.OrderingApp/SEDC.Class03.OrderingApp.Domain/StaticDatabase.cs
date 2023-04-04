using SEDC.Class03.OrderingApp.Domain.Enums;
using SEDC.Class03.OrderingApp.Domain.Models;

namespace SEDC.Class03.OrderingApp.Domain
{
    // This static class is serving as a temporary database
    // While the app is running, the static members of this class will keep their data
    // It can also be accessed from anywhere
    public static class StaticDatabase
    {

        // Static Constructor
        // Static class will only instantiate once, the first time we use it
        // Static constructor does not have access modifier
        static StaticDatabase()
        {
            SeedData();
            TextHelper.WriteLineInColor("Database initialized...", ConsoleColor.DarkGreen);
            CurrentOrderId = Orders.Count;
        }

        // This is a private field that helps us auto-increment order IDs
        private static int CurrentOrderId;

        // These are the lists that will serve as tables in a database ( Store items in them )
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Order> Orders { get; set; } = new List<Order>();

        public static void InsertOrder(User userMakingTheOrder, Order order)
        {
            // When an order is added, we increment the ID and set it to the new order
            order.Id = ++CurrentOrderId;
            Orders.Add(order);
            userMakingTheOrder.Orders.Add(order);

            TextHelper.WriteLineInColor("Order successfully added!", ConsoleColor.DarkGreen);
        }

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
