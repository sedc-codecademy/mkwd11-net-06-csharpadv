using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClasses.Entities
{
    public class Square : Shape
    {
        public int SideLength { get; set; }

        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
