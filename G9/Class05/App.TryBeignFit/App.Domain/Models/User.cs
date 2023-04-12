
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get;set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }
    }
}
