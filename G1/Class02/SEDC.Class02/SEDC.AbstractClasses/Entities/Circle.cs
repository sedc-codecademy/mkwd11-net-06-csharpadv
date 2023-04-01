using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClasses.Entities
{
    public class Circle : Shape
    {
        public Circle()
        {
            
        }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
    }
}
