using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager.Services.Utilities
{
    public static class StringValidator
    {
        public static int ValidateNumber(string number, int range) 
        {
            int num = 0;

            bool isNumber = int.TryParse(number, out num);

            if (!isNumber) 
            {
                return -1;
            }

            if (num <= 0 || num > range) 
            {
                return -1;
            }

            return num;
        }
        public static string? ValidateString(string str) 
        {
            if (str.Length < 2) 
            {
                return null;
            }

            if (int.TryParse(str, out int number)) 
            {
                return null;
            }

            return str;
        }
        public static bool ValidateUsername(string username) 
        {
            if (username.Length < 6) 
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

            return true;
        }       
    }
}
