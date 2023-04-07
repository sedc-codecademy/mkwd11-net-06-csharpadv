using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class04.Generics.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public void Print()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}
