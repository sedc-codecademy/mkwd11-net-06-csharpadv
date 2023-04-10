using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Pet
    {
        public string Name { get; set; }

        public virtual void Eat() 
        {
            Console.WriteLine("Nom nom nom");
        }
    }
}
