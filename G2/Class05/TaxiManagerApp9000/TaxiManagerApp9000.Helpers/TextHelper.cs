namespace TaxiManagerApp9000.Helpers
{
    public static class TextHelper
    {
        public static void TextGenerator(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
