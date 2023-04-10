using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoy { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Nom nom noming on dog food!");
        }
    }
}
