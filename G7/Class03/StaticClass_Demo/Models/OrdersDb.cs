namespace Models
{
    public static class OrdersDb
    {
        public static List<Order> Orders;
        public static List<User> Users;

        static OrdersDb()
        {
            Orders = new List<Order>
            {
                new Order("To Gjorce Petrov", "2xBeers"),
                new Order("to Karpos", "1xPizza"),
                new Order("to Karpos", "3xBeers & Family pizza")
            };

            Users = new List<User>
            {
                new User("risto", "Skopje"),
                new User("tijana", "Karpos")
            };

            Users[0].Orders = new List<Order> { Orders[0] };
            Users[1].Orders = new List<Order> { Orders[1], Orders[2] };
        }

        public static void InsertOrder(int userId, Order order)
        {
            User userFromDb = Users.FirstOrDefault(x => x.Id == userId);

            if(userFromDb == null)
            {
                throw new Exception($"User with Id: {userId}, does not exist");
            }

            Orders.Add(order);
            userFromDb.Orders.Add(order);
        }

        public static string GetAllUsers()
        {
            string text = string.Empty;
            foreach(User u in Users)
            {
                text += u.GetInfo() + "\n";
            }

            return text;
        }

        public static User GetUser(int userId)
        {
            User userFromDb = Users.FirstOrDefault(x => x.Id == userId);

            if (userFromDb == null)
            {
                throw new Exception($"User with Id: {userId}, does not exist");
            }

            return userFromDb;
        }
    }
}
