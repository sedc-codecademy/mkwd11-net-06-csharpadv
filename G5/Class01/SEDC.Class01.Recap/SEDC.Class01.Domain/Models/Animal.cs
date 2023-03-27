using SEDC.Class01.Domain.Enums;

namespace SEDC.Class01.Domain.Models
{
    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public AnimalType Type { get; set; }

        // the keyword 'virtual' means that this method could be overriden from some class that inherits Animal
        public virtual void PrintInfo() 
        {
            Console.WriteLine($"Hello, I am {Name}, the {Type}");
        }

        public virtual void MyFavouriteFood(string food)
        {
            Console.WriteLine($"My favourite food is {food}");
        }
    }
}
