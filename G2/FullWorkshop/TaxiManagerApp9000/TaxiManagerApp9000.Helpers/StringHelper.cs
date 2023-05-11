namespace TaxiManagerApp9000.Helpers
{
    public static class StringHelper
    {
        public static int validateNumber(string input, int range)
        {
            int number = -1;
            if (int.TryParse(input, out number))
            {
                if (number <= range && number > 0)
                    return number;
                return -1;
            }
            return -1;
        }
    }
}
