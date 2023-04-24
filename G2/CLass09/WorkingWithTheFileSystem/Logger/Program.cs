using FileSystem;
using Logger;

LoggerService loggerService = new LoggerService();

List<User> users = new List<User>()
{
    new User() { Id = 1,
    FirstName = "Bojan",
    LastName = "Damchevski",
    Password = "123",
    Username = "boksance"},
    new User() { Id = 2,
    FirstName = "Ilija",
    LastName = "Mitev",
    Password = "123",
    Username = "ivcepivce"}
};

void Login(string username, string password)
{
    User user = users.FirstOrDefault(x => x.Username == username && x.Password == password);

    if (user == null)
    {
        throw new Exception($"Invalid login for {username}");
    }
}

try
{
    TextHelper.TextGenerator("Enter a username:", ConsoleColor.Yellow);
    string username = Console.ReadLine();

    TextHelper.TextGenerator("Enter a password:", ConsoleColor.Yellow);
    string password = Console.ReadLine();

    loggerService.Log($"Trying to log in a user with the username: {username}");

    Login(username, password);
}
catch (Exception ex)
{
    TextHelper.TextGenerator("An error occured", ConsoleColor.Red);
    TextHelper.TextGenerator(ex.Message, ConsoleColor.Yellow);

    loggerService.Log(ex.Message, true);
}