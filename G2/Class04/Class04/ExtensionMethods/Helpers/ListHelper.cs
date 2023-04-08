namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        public static void Print<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetInfo<T>(this List<T> items)
        {
            Console.WriteLine($"This list has {items.Count} members and is of type {items.GetType().Name}!");
        }

        public static string CapitalizeFirstLetter(this string word, string name)
        {
            string text = char.ToUpper(word[0]) + word.Substring(1) + " " + name;

            return text;
        }

        public static void ColorText(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
