using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.NullableAndOptionalParams
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Score { get; set; }
        //public Nullable<int> Score { get; set; }
        public bool? HasWon { get; set; }
    }
}
