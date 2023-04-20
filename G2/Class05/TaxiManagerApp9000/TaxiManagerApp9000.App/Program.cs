using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;
using TaxiManagerApp9000.Helpers;
using TaxiManagerApp9000.Services;

UserService userService = new UserService();

User user1 = new User("admin", "admin", Role.Administrator);
User user2 = new User("manager", "manager", Role.Manager);

void InitializeData()
{
    userService.Add(user1);
    userService.Add(user2);
}

InitializeData();

while (true)
{
    User loggedInUser = LogInUser();

    if (loggedInUser.Role == Role.Administrator)
    {
        AdminMenu();
    }

    if (loggedInUser.Role == Role.Maintenance)
    {
        MaintananceMainMenu();
    }

    if (loggedInUser.Role == Role.Manager)
    {
        ManagerMainMenu();
    }

    break;
}

User LogInUser()
{
    while (true)
    {
        Console.Clear();
        TextHelper.TextGenerator("TAXI APP 9000", ConsoleColor.Blue);
        TextHelper.TextGenerator("Log in to the app", ConsoleColor.Blue);
        TextHelper.TextGenerator("\n\nEnter username: ", ConsoleColor.Blue);
        string usernameInput = Console.ReadLine();

        if (string.IsNullOrEmpty(usernameInput))
        {
            TextHelper.TextGenerator("Invalid input !", ConsoleColor.Red);
            Console.ReadKey();
            continue;
        }

        TextHelper.TextGenerator("Enter pasword: ", ConsoleColor.Blue);
        string passwordInput = Console.ReadLine();

        if (string.IsNullOrEmpty(passwordInput))
        {
            TextHelper.TextGenerator("Invalid input !", ConsoleColor.Red);
            Console.ReadKey();
            continue;
        }

        User loggedInUser = userService.Login(usernameInput, passwordInput);

        if (loggedInUser == null)
        {
            TextHelper.TextGenerator($"No user with the username: {usernameInput} found, please try again.", ConsoleColor.Yellow);
            Console.ReadKey();
            continue;
        }

        return loggedInUser;
    }
}

void AdminMenu()
{
    while (true)
    {
        Console.Clear();
        TextHelper.TextGenerator("Admin main menu", ConsoleColor.Blue);
        TextHelper.TextGenerator("1.) Add new user", ConsoleColor.Blue);
        TextHelper.TextGenerator("2.) Delete a user", ConsoleColor.Blue);
        TextHelper.TextGenerator("3.) Change password", ConsoleColor.Blue);
        TextHelper.TextGenerator("4.) Exit", ConsoleColor.Blue);

        int choice = inputValidation();

        if (choice == 4)
        {
            break;
        }
    }
}

void MaintananceMainMenu()
{
    while (true)
    {
        Console.Clear();
        TextHelper.TextGenerator("1.) List all vehicles", ConsoleColor.Blue);
        TextHelper.TextGenerator("2.) License plate status", ConsoleColor.Blue);
        TextHelper.TextGenerator("3.) Change password", ConsoleColor.Blue);
        TextHelper.TextGenerator("4.) Exit", ConsoleColor.Blue);

        int choice = inputValidation();

        if (choice == 4)
        {
            break;
        }
    }
}

void ManagerMainMenu()
{
    while (true)
    {
        Console.Clear();
        TextHelper.TextGenerator("1.)  List all drivers", ConsoleColor.Blue);
        TextHelper.TextGenerator("2.) Taxi license status", ConsoleColor.Blue);
        TextHelper.TextGenerator("3.) Driver manager", ConsoleColor.Blue);
        TextHelper.TextGenerator("4.) Change password", ConsoleColor.Blue);
        TextHelper.TextGenerator("5.) Exit", ConsoleColor.Blue);

        int choice = inputValidation();

        if (choice == 5)
        {
            break;
        }
    }
}

int inputValidation()
{
    string input = Console.ReadLine();
    bool inputValidation = int.TryParse(input, out int choice);

    if (!inputValidation)
    {
        TextHelper.TextGenerator("Invalid input, try again", ConsoleColor.Red);
        Console.ReadKey();
    }

    return choice;
}