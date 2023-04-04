using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControledGenerics
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }

        public string Address { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"{Id} {Receiver} - {Address}");
        }

      
    }
}
