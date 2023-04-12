using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models
{
    public class Trainer : User
    {
        public Trainer()
        {
            Role = Role.Trainer;
        }
    }
}
