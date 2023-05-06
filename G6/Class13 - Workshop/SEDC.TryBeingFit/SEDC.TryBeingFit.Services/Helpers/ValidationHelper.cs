using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateName(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateUsername(string userName)
        {
            if (userName.Length < 6)
            { 
                return false;
            }
            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }

            //if(password.Contains("9") || password.Contains("8") ... )

            //Test123 
            foreach(char c in password)
            {
                bool isParsed = int.TryParse(c.ToString(), out int num);
                if (isParsed)
                    return true;
            }

            return false;
        }

        public static bool ValidateTrainingDuration(double duration)
        {
            if (duration < 10)
                return false;
            return true;
        }
    }
}
