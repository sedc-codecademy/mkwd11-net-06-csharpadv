using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11_DatabaseJsonDemo
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price) : base()
        {
            Name = name;
            Price = price;
        }

        public override string GetInfo()
        {
            return $"{Name} - {Price}";
        }
    }
}
