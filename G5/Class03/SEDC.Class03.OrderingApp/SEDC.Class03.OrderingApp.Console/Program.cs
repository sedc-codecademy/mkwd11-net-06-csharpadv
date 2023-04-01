using SEDC.Class03.OrderingApp.Domain;
using SEDC.Class03.OrderingApp.Domain.Models;

// Ordering App ( AliExpress / eBay )

// Main Menu
// 1. Choose a User

// Orders Menu
// When the user logs, it should have options to:
// - Check Orders
// - Create New Order

// Bonus:
// - On the main menu showcase how many times the all users checked their order
// ex. Fun fact: People checked their order status 5 times !

// * Create Static Database
// * Create Static Text Helper
// * Create Static Property in Non-Static Class
// * Create customer getter and setter on atleast one property


User currentUser = null;

while (true)
{
    #region Main Menu

    Console.Clear();
    Console.WriteLine("Main Menu");

    StaticDatabase.ListUsers();
    Console.Write("Choose User: ");

    int choice = TextHelper.ValidateNumber(Console.ReadLine());

    if (choice == -1)
        continue;

    if (choice > StaticDatabase.Users.Count)
    {
        TextHelper.WriteLineInColor("User does not exist!", ConsoleColor.DarkRed);
        Console.ReadKey();
        continue;
    }

    currentUser = StaticDatabase.Users[choice - 1];

    #endregion

    #region Orders Menu
    while (currentUser != null)
    {
        Console.Clear();
        Console.WriteLine($"Welcome {currentUser.Username}");
        Console.WriteLine();
        Console.WriteLine("Orders Menu");
        Console.WriteLine("1) Check Orders");
        Console.WriteLine("2) Create New Order");
        Console.WriteLine("3) Exit");
        Console.Write("> ");

        int menuChoice = TextHelper.ValidateNumber(Console.ReadLine());

        if (menuChoice == -1)
            continue;

        switch (menuChoice)
        {
            case 1:
                Console.Clear();
                currentUser.PrintOrders();
                Console.WriteLine("Choose one to check the status: ");

                int orderChoice = TextHelper.ValidateNumber(Console.ReadLine());
                if (orderChoice == -1)
                    continue;

                if (orderChoice > currentUser.Orders.Count)
                {
                    TextHelper.WriteLineInColor("Order not found!", ConsoleColor.DarkRed);
                    Console.ReadKey();
                    continue;
                }


                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Choice 2");
                break;
            case 3:
                currentUser = null;

                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                break;
            default:
                TextHelper.WriteLineInColor("Invalid Input", ConsoleColor.DarkRed);
                Console.ReadKey();
                continue;
        }


    }
    #endregion
}
