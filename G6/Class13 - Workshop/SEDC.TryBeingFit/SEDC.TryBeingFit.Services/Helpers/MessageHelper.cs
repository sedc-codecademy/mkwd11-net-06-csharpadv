using System;

namespace SEDC.TryBeingFit.Services.Helpers
{
    public static class MessageHelper
    {
        public static void PrintMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
