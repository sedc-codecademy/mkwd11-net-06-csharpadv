using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11_DatabaseJsonDemo
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public FuelTypeEnum FuelType { get; set; }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
