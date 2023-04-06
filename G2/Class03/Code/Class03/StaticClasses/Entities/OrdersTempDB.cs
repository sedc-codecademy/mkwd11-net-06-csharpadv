using StaticClasses.Entities.Enums;

namespace StaticClasses.Entities
{
    public static class OrdersTempDB
    {
        public static int orderId = 5;

        public static List<User> Users;

        public static List<Order> Orders;

        static OrdersTempDB()
        {
            Orders = new List<Order>() {
                new Order(1, "book of books","best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard","description", OrderStatus.DeliveryInProgress),
                new Order(3, "shoes","waterproof", OrderStatus.DeliveryInProgress),
                new Order(4, "set of pens","some pens", OrderStatus.Processing),
                new Order(5, "notes","some notes", OrderStatus.CouldNotDeliver)
            };

            Users = new List<User>()
            {
                new User(12,"Bob22","bob st. 44"),
                new User(13, "JillCoolCat","Wayne st. 432")
            };

            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

        public static void ListUsers()
        {
            for(int i = 1; i<= Users.Count; i++)
            {
                Console.WriteLine($"{i}) {Users[i-1].Username}");
            }
        }

        public static void InsertOrder(int userId, Order order)
        {
            order.Id = ++orderId;
            Orders.Add(order);
            Users.Single(x => x.Id == userId).Orders.Add(order);
            Console.WriteLine("Order successfully added!!!");
        }
    }
}
