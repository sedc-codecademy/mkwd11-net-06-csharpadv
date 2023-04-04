

using StaticClasses.Domain.Enums;
using StaticClasses.Domain.Helpers;

namespace StaticClasses.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
            Id = new Random().Next(1, 100000);
            Status = OrderStatus.Created;
        }

        public Order(int id, string title, string description, OrderStatus status)
        {
            //todo validation
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }

        public void Print()
        {
            //Because TextHelper is a static class, we can call the method without creating an instance
            Console.WriteLine($" {TextHelper.ToCapitalFirstLetter(Title)} {Description} {Status.ToString()}");
        }
    }
}
