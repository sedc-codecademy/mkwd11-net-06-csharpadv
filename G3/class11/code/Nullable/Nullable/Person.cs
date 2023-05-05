using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    public class Person
    {
        public int Id { get; set; }
        public int? Score { get; set; }
        public bool IsEmployed { get; set; }
        public bool? HasPet { get; set; }

        public string Name { get; set; }
        public string? Username { get; set; }
    }
}
