using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo02
{
    //Restricting so T is not wide range of object (all objects), but T can be only an object that is created from a class that inherits from BaseEntity
    public static class Helper<T> where T : BaseEntity
    {
        public static int CalculateAge(T item)
        {
            int age = DateTime.Now.Year - item.DateOfBirth.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (item.DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

            return age;
        }
    }
}
