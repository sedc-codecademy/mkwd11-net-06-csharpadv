using SEDC.Class01.Domain.Enums;

namespace SEDC.Class01.Domain.Models
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) // base constructor is the inherited class constructor (Animal)
        {
            Type = AnimalType.Dog;
        }

        public void Bark()
        {
            // This method is specific only for Dog, you cannot use it on object created from the Animal class
            Console.WriteLine("Woof Woof");
        }

        public override void PrintInfo()
        {
            // Override without base completely overrides the implementation of the specific method
            Console.WriteLine($"Hello, I am {Name}, the {Type}, Woof Woof!");
        }

        public override void MyFavouriteFood(string food)
        {
            Console.WriteLine("Dogs Favourite Food:");
            // Base will call MyFavouriteFood inside the inherited class ( Animal )
            base.MyFavouriteFood(food);
        }
    }
}
