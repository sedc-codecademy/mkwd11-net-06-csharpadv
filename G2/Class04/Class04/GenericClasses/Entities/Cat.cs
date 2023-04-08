namespace GenericClasses.Entities
{
    public class Cat : BaseEntity
    {
        public bool IsNice { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Cat info:\nName:{Name}\nIs the cat nice: {(IsNice ? "yes" : "no")}");
        }
    }
}
