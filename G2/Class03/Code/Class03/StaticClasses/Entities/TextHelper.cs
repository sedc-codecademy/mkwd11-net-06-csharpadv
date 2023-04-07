using StaticClasses.Entities.Enums;

namespace StaticClasses.Entities
{
    public static class TextHelper
    {
        public static int MessagesGenerated = 0;

        public static void GenerateStatusMessages(OrderStatus status)
        {
            string result = "";
            switch (status)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Processing] The order is being processed.";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Delivered] The order is successfully delivered.";
                    break;
                case OrderStatus.DeliveryInProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "[Delivery In Progress] The delivery is in progress.";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Could Not Deliver] There is a problem with the delivery.";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ResetColor();
            MessagesGenerated++;
        }

        public static string CapitalFirstLetter(string word)
        {
            if (word.Length == 0)
            {
                return "Empty word";
            }
            else if (word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }

        public static int ValidateNumberInput(string input)
        {
            int choice = 0;
            bool isMenuChoiceValid = int.TryParse(input, out choice);
            if (!isMenuChoiceValid)
            {
                Console.WriteLine("Wrong input...");
                return -1;
            }

            return choice;
        }
    }
}
