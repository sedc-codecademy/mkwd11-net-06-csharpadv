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

        public static bool ValidateUsername(string username)
        {
            if (username.Length < 6)
                return false;
            return true;
        }

        public static bool ValidateName(string name)
        {
            if (name.Length < 2)
                return false;
            return true;
        }

        public static int ValidateNumber(string numberInput, int range)
        {
            bool isNumber = int.TryParse(numberInput, out int number);
            if (!isNumber)
                return -1;
            if (number < 1 || number > range)
                return -1;
            return number;
        }
    }
}
