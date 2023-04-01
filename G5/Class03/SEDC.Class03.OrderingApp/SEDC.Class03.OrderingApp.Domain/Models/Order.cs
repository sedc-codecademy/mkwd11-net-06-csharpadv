using SEDC.Class03.OrderingApp.Domain.Enums;

namespace SEDC.Class03.OrderingApp.Domain.Models
{
    public class Order
    {
        public Order(int id, string title, string description, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }

        public int Id{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public string Print()
        {
            return $"{Title} - {Description}";
        }
    }
}
