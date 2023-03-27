using SEDC.Class01.Domain.Enums;

namespace SEDC.Class01.Domain.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string color) : base(name)
        {
            Type = AnimalType.Cat;
            Color = color;
        }

        // Specific Cat property 
        public string Color { get; set; }

        public void Meow()
        {
            // This method is specific only for Cat, you cannot use it on object created from the Animal class
            Console.WriteLine("Meow Meow");
        }
    }
}
