using System.Globalization;

namespace Models.Helpers
{
    public static class TextHelper
    {
        //public static string ToUpperCaseFirstLetter(string text)
        //{
        //    TextInfo ti = new CultureInfo("mk-MK").TextInfo;

        //    return ti.ToTitleCase(text.ToLower());
        //}

        public static string ToUpperCaseFirstLetter(string text)
        {
            string textToLower = text.ToLower();

            string firstLetter = textToLower.Substring(0, 1);
            string restOfTheLetters = textToLower.Substring(1);

            return firstLetter.ToUpper() + restOfTheLetters;
        }
    }
}
