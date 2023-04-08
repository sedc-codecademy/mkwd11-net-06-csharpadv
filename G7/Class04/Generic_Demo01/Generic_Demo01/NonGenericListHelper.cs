namespace Generic_Demo01
{
    public static class NonGenericListHelper
    {
        public static string GetFormatedItemsOfStringList(List<string> strings)
        {
            return string.Join(", ", strings);

            //string text = "";
            //foreach(string s in strings)
            //{
            //    text += s + ", ";
            //}

            //return text;
        }

        public static string GetFormatedItemsOfIntList(List<int> ints)
        {
            return string.Join(", ", ints);
        }

        public static string GetFormatedItemsOfCharList(List<char> chars)
        {
            return string.Join(", ", chars);
        }

        public static string PrintInfoForStringList(List<string> strings)
        {
            return $"The list has {strings.Count} items. They are of type {strings.First().GetType().Name}";
        }

        public static string PrintInfoForIntsList(List<int> ints)
        {
            return $"The list has {ints.Count} items. They are of type {ints.First().GetType().Name}";
        }

        public static string PrintInfoForCharsList(List<char> chars)
        {
            return $"The list has {chars.Count} items. They are of type {chars.First().GetType().Name}";
        }
    }
}
