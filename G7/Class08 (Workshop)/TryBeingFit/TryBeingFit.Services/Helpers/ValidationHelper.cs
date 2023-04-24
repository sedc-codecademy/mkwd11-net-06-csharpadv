using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        //P@ssw0rd
        public static bool ValidPassword(string password)
        {
            if(password.Length < 8)
            {
                return false;
            }

            bool containsNumber = false;

            //List<char> items = password.ToCharArray().ToList();

            //if(!items.Any(x => int.TryParse(x.ToString(), out int number)))
            //{
            //    return false;
            //}

            foreach(char c in password)
            {
                if(int.TryParse(c.ToString(), out int number))
                {
                    containsNumber = true;
                    break;
                }
            }

            if(!containsNumber)
            {
                return false;
            }

            return true;
        }
    }
}
