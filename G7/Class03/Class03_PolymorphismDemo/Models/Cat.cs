using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Pet
    {
        public int Age { get; set; }

        public override string Eat()
        {
            return "Calling Eat function from Cat class";
        }
    }
}
