using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Poly.Entities
{
    public class Dog : Pet
    {
        public string Breed { get; set; }
        public Dog(string name, string breed) : base(name) 
        {
            Breed = breed;
        }


        /// <summary>
        /// This is a method that will tell you that the dog is eating
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }
    }
}
