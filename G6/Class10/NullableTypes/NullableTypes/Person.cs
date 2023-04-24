using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    public class Person
    {
        public int Id { get; set; } //default 0

        //nullable int as type, Score has default value null
        //Score can get any whole number as value, but it can also get null as value
        public int? Score { get; set; }

        public bool IsStudent { get; set; } //default false

        //IsEmployed can get true, false, null as value
        public bool? IsEmployed { get; set; } //default null

        public string Name { get; set; } //default null

        //default null, because it is a reference type, it should hold an instance of List class
        public List<int> Numbers { get; set; } 
    }
}
