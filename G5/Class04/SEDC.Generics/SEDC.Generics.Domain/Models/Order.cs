using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Generics.Domain.Models
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }
        public string Address { get; set; }
        public override string GetInfo()
        {
            return $"{Id}) {Address} - {Receiver}";  
        }
    }
}
