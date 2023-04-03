using System.Threading.Channels;

namespace SEDC.Class03.OrderingApp.Domain.Models
{
    public class User
    {
        // Static Property / Private Fielod in non-static class is property of the class instead of the instantiated object out of it ( You access it directly from the class User._userCounter )
        private static int _userCounter = 1;

        public User(string username, string address)
        {
            Id = _userCounter;
            Username = username;
            Address = address;

            _userCounter++;
        }

        public int Id { get; set; }
        public string Username { get; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public void PrintOrders()
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                // 1) Ball - Description...
                Console.WriteLine($"{i + 1}) {Orders[i].Print()}");
            }
        }
    }
}
