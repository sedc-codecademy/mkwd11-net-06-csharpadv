using StaticClasses.Entities.Enums;

namespace StaticClasses.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public OrderStatus OrderStatus { get; set; }

        public Order()
        {
            OrderStatus = OrderStatus.Processing;
        }

        public Order(int id, string title, string description, OrderStatus orderStatus)
        {
            Id = id;
            Title = title;
            Description = description;
            OrderStatus = orderStatus;
        }

        public string Print()
        {
            return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
        }
    }
}
