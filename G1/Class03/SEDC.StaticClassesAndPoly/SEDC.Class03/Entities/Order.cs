using SEDC.Class03.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, string description, OrderStatus status)
        {
            Id = id;
            Description = description;
            Status = status;
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine($"{StringUtils.CapitaliseFirstLetter(Description)} - {Status}");
        }
    }
}
