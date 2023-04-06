using Models.Helpers;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatusEnum Status { get; set; }

        public Order(string title, string description)
        {
            Random rnd = new Random();
            Id = rnd.Next(1, int.MaxValue);
            Title = title;
            Description = description;
            Status = OrderStatusEnum.Created;
        }

        public string GetInfo()
        {
            string formattedTitle = TextHelper.ToUpperCaseFirstLetter(Title);

            return $"{formattedTitle}\n{Description}\nStatus: [{Status}]";
        }
    }
}