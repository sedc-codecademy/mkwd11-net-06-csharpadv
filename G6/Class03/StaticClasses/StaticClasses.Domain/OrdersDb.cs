using StaticClasses.Domain.Enums;
using StaticClasses.Domain.Models;

namespace StaticClasses.Domain
{
    //This static class simulates database
    //It is alive during the lifecycle of the application together with its members
    //Can be accessed from anywhere
    public static class OrdersDb
    {
        //these lists simulate tables in a real database
        public static List<Order> Orders;
        public static List<User> Users;

        public static int lastOrderId = 5;

        //static constructor, which is called only once, the first time we use the OrdersDb class
        static OrdersDb()
        {
            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProcess),
                new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProcess),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.Problem)
            };
            Users = new List<User>()
            {
                new User(12, "Bob22", "Bob St. 44"),
                new User(13, "JillCoolCat", "Wayne St. 109a")
            };
            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

        public static void PrintUsers()
        {
            int i = 1;
            foreach(User user in Users)
            {
                Console.WriteLine($"{i}) {user.Username}");
                i++;
            }
        }

        public static void InsertOrder(int userId, Order order)
        {
            //simulate that the database generates the id, it should be + 1 from the last generated id
            lastOrderId++;
            order.Id = lastOrderId;
            //add the order in the table (general list for the application)
            Orders.Add(order);
            //find the user by id and add the order
            User userFromDb = Users.First(x => x.Id == userId);
            userFromDb.Orders.Add(order);

        }
    }
}
