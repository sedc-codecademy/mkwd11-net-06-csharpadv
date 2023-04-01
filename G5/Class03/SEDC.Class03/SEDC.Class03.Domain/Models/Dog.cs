namespace SEDC.Class03.Domain.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating...");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The dog {Name} is eating {food}");
        }
    }
}
