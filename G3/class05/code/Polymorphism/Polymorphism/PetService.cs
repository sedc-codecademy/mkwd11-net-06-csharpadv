using Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PetService
    {
        public void PetStatus(Dog pet, string ownerName) 
        {
            Console.WriteLine($"Hey there {ownerName}");

            if (pet.IsGoodBoy)
            {
                Console.WriteLine("This dog is a good boy :)");
            }
            else 
            {
                Console.WriteLine("This dog is not really a good boy :(");
            }
        }

        public void PetStatus(string ownerName, Dog pet)
        {
            Console.WriteLine($"Hey there {ownerName}. Happy to see you again!");

            if (pet.IsGoodBoy)
            {
                Console.WriteLine("This dog is still a good boy :)");
            }
            else 
            {
                Console.WriteLine("This dog is still not really a good boy :(");
            }
        }

        public void PetStatus(Cat pet, string ownerName) 
        {
            Console.WriteLine($"Hey there {ownerName}");

            if (pet.IsLazy)
            {
                Console.WriteLine("This cat is really lazy :(");
            }
            else 
            {
                Console.WriteLine("This cat is cool and not lazy at all :)");
            }
        }

        public void PetStatus(Cat pet)
        {
            Console.WriteLine($"Hey, a cat with no owner.");

            if (pet.IsLazy)
            {
                Console.WriteLine("This cat is really lazy :(");
            }
            else 
            {
                Console.WriteLine("This cat is cool and not lazy at all :)");
            }
        }
    }
}
