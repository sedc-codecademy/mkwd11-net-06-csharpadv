namespace GenericClasses.Entities
{
    public class Dog : BaseEntity
    {
        public bool IsSheperd { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Dog info:\nName:{Name}\nIs the dog a shepherd: {(IsSheperd ? "yes" : "no")}");
        }
    }
}
