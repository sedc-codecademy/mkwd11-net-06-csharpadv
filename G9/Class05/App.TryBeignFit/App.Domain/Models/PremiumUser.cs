using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Models
{
    public class PremiumUser : User
    {
        public PremiumUser()
        {
            Role = Role.PremiumUser;
        }
        public LiveTraining LiveTraining { get; set; }
    }
}
