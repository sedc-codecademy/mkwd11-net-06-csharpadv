using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Domain.Models
{
    public class Cat : Pet
    {  
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Calling Eat method from Cat class");
        }
    }
}
