using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class11.StudentApp.Domain.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get;set; }    
        public string LastName { get;set; }    
        public int Age { get;set; }    
        public bool IsLazy { get;set; }    
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - {Age} years old! Lazy: {IsLazy}";
        }
    }
}
