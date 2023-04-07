using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroExercise
{
    public static class DogShelter
    {
        public static List<Dog> Dogs;

        static DogShelter()
        {
            Dogs = new List<Dog>()
            {
                new Dog()
                {
                    Id = 1,
                    Name = "Barky",
                    Color = "Black"
                },
                new Dog()
                {
                    Id = 2,
                    Name = "Sparky",
                    Color = "Brown"
                }
            };
        }

        public static void PrintAll()
        {
            foreach(Dog dog in Dogs)
            {
                Console.WriteLine($"{dog.Id}. {dog.Name} {dog.Color}");
            }
        }
    }
}
