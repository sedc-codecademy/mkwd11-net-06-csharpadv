namespace TaxiManagerApp9000.Helpers
{
    public static class TextHelper
    {
        public static void TextGenerator(string text, ConsoleColor color)//this just changes the color of the text
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static string GetInput(string text)//this will be something like Please insert something: (user input goes here)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        //Do I even have to talk about this ?
        public static void Separator() => Console.WriteLine("==========================================================");
    }
}
