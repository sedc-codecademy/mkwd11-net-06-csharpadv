using SEDC.Class15.ITCompnay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompnay.Domain.Models
{
    public class NetworkEngeneer : User
    {
        public int Experience { get; set; }
        public Level Level { get; set; }
        public NetworkEngeneer()
        {
            Role = Role.NetworkEngeneer;
        }
        public override string GetInfo()
        {
            return $"I'm {FirstName} {LastName} and I'm {Age} years old. I have {Experience} years experience and I'm {Level} network engeneer ";
        }
    }
}
