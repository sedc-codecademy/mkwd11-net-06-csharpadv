using SEDC.Class03.Domain.Models;

namespace SEDC.Class03.Domain
{
    public class PetService
    {
        public void PetStatus(Dog pet, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if (pet.IsGoodBoi)
            {
                Console.WriteLine("This dog is a good boi");
            }
            else
            {
                Console.WriteLine("This dog is not really a good boi");
            }
        }

        public void PetStatus(string ownerName, Dog pet)
        {
            Console.WriteLine($"Hey there {ownerName}. Happy to see you again!");
            if (pet.IsGoodBoi)
            {
                Console.WriteLine("This dog is a good boi");
            }
            else
            {
                Console.WriteLine("This dog is not really a good boi");
            }
        }

        public void PetStatus(Cat pet, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");

            if (pet.IsLazy)
            {
                Console.WriteLine("The cat is really lazy");
            }
            else
            {
                Console.WriteLine("This cat is cool and not lazy at all");
            }
        }

        public void PetStatus(Pet pet)
        {
            Console.WriteLine($"Your pet {pet.Name} is hungry");
            pet.Eat();
        }
    }
}
