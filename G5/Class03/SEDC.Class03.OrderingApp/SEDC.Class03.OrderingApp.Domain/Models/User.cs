using System.Threading.Channels;

namespace SEDC.Class03.OrderingApp.Domain.Models
{
    public class User
    {
        private static int _userCounter = 1;
        public User(string username, string address)
        {
            Id = _userCounter;
            Username = username;
            Address = address;

            _userCounter++;
        }

        public int Id { get; set; }
        public string Username { get; set; }
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
