using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Poly.Entities
{
    public class Cat : Pet
    {
        public string Color { get; set; }

        public Cat(string name, string color) : base(name)
        {
            Color = color;
        }

        /// <summary>
        /// This is a method that will tell you that the cat is eating
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("The cat is eating");
        }
    }
}
