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

        public static string GetInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static void Separator() => Console.Write("==========================================================");
    }
}
