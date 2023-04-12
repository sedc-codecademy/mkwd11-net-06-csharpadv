using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models
{
    public class Training : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public override void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
