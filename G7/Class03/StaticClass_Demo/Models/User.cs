using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }

        public User(string username, string address)
        {
            Random rnd = new Random();
            Id = rnd.Next(1, int.MaxValue);
            Username = username;
            Address = address;
        }

        public string GetInfo()
        {
            return $"{Id}. {Username} - {Address}";
        }

        public string GetOrdersInfo()
        {
            string text = "----------------------\n";

            Orders.ForEach(order =>
            {
                text += order.GetInfo();
                text += "\n----------------------\n";
            });

            if(!Orders.Any())  //Orders.Count == 0
            {
                text += "No orders!";
                text += "\n----------------------\n";
            }

            return text;
        }
    }
}
