namespace Recap
{
    public static class StaticHelper
    {
        public static void PrintTextWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void PrintTextWithExtensionMethod(this string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintTextWithExtensionMethodAndParameter(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
