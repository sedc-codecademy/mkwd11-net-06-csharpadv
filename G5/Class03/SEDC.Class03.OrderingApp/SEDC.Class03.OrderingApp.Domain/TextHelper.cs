namespace SEDC.Class03.OrderingApp.Domain
{
    public static class TextHelper
    {
        public static void WriteLineInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static int ValidateNumber(string input)
        {
            bool isValid = int.TryParse(input, out int choice);
            if (!isValid)
            {
                WriteLineInColor("Invalid Input...", ConsoleColor.DarkRed);
                Console.ReadKey();
                return -1;
            }

            return choice;
        }
    }
}
