using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class10.Nullable.Domain
{
    public class Person
    {
        public int Id { get; set; } //default 0
        //nullable int as type, Score has default value null
        //Score can get any whole number as value, but it can also get null as value
        public int? Score { get; set; } //default null

        public uint PositiveNumber { get; set; } // Positive integer
        public uint? PositiveNumberNullable { get; set; } // Positive integer null

        public bool IsStudent { get; set; } //default false
        public bool? IsEmployed { get; set; } // default null

        public string Name { get; set; } //default null

        //Nullable method
        public bool? isTrue(bool? isTrue)
        {
            return isTrue;
        }

        public bool? isFalse()
        {
            return null;
        }

        public int? Number()
        {
            return null;
        }

        public string Text()
        {
            return null;
        }
    }
}
