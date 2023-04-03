using SEDC.Class03.OrderingApp.Domain.Enums;

namespace SEDC.Class03.OrderingApp.Domain.Models
{
    public class Order
    {
        public Order()
        {
            Status = OrderStatus.Processing;
        }

        public Order(int id, string title, string description, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }

        // You need to have private field if you are manipulating with custom getter/setter to prevent recursion in the setter
        private string _title;

        public int Id { get; set; }
        public string Title
        {
            get => _title;
            set => _title = TextHelper.CapitalizeFirstLetter(value);
        }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public string Print()
        {
            return $"{Title} - {Description}";
        }
    }
}
