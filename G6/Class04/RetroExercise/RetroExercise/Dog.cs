using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroExercise
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine($"The dog {Name} is barking.");
        }

        public static bool Validate(Dog dog)
        {
            if(string.IsNullOrEmpty(dog.Name)) 
                return false;

            if (string.IsNullOrEmpty(dog.Color))
                return false;

            if (dog.Name.Length < 2)
                return false;

            if(dog.Id < 0)
                return false;

            return true;
        }
    }
}
