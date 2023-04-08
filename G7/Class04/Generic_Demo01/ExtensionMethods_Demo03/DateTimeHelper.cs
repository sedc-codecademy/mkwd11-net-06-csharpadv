namespace ExtensionMethods_Demo03
{
    public static class DateTimeHelper
    {
        public static int CalculateAges(this DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (dateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

            return age;
        }
    }
}
