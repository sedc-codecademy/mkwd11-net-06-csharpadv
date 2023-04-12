using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Helpers
{
    public static class Validators
    {
        public static bool ValidateFirstName(string firstName)
        {
            if (firstName.Length < 2)
                return false;
            else return true;
        }

        public static bool ValidateUsername(string username)
        {
            if (username.Length < 6)
                return false;
            else return true;
        }

        public static bool ValidatePassword(string password)
        {
            // 1 nacin
            bool existNumber = false;
            foreach(var character in password)
            {
                bool checkNumber = int.TryParse(character.ToString(), out int b);
                if(checkNumber)
                {
                    existNumber = true;
                    break;
                }
            }

            if (existNumber && password.Length>=6) return true;
            else return false;

            // 2 nacin
            //bool existNumberCheck = password.Any(char.IsDigit);

        }
    }
}
