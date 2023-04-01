namespace SEDC.Class03.Domain.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating...");
        }
    }
}