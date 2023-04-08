using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidatePassword(string password)
        {
            if(password.Length < 6)
            {
                return false;
            }
            bool isNum = false;
            foreach(char ch in password)
            {
                isNum = int.TryParse(ch.ToString(), out int num);
                if (isNum)
                    break;
            }
            if (!isNum)
                return false;

            return true;
        }
    }
}
