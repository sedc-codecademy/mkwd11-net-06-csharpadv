using StaticClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class DogShelter
    {
        public static List<Dog> Dogs;

        static DogShelter()
        {
            Dogs = new List<Dog>();
        }

        public static void PrintAll() 
        {
            foreach (Dog dog in Dogs) 
            {
                if (Dog.Validate(dog)) 
                {
                    Console.WriteLine($"{dog.Name} - {dog.Color}");
                }
            }
        }
    }
}
