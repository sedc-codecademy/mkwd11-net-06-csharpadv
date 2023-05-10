using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompnay.Domain.Models
{
    public class ProjectManager : User
    {
        public string Company { get; set; }
        public List<SoftwareEngeneer> SoftwareEngeneers { get; set; }
        public List<NetworkEngeneer> NetworkEngeneers { get; set; }
        public List<QATester> QATesters { get; set; }
        public override string GetInfo()
        {
            return $"My name is {FirstName} {LastName} and I am {Age} years old. I'm Project Manager at {Company} company";
        }
    }
}
