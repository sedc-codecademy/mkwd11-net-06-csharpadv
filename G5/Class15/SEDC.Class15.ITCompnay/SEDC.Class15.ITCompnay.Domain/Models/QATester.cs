using SEDC.Class15.ITCompnay.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompnay.Domain.Models
{
    public class QATester : User
    {
        public QAType QAType { get; set; }
        public QATester()
        {
            Role = Role.QATester;
        }
        public override string GetInfo()
        {
            return $"I'm {FirstName} {LastName} and I'm {Age} years old. I'm {QAType} tester";
        }
    }
}
