using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControledGenerics
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"{Id} {Title} - {Description}");
        }

       
    }
}
