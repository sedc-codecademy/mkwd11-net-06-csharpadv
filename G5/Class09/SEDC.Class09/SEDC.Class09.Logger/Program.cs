using SEDC.Class09.Logger.CustomExceptions;
using SEDC.Class09.Logger.Models;
using SEDC.Class09.Logger.Services;

LoggerService logger = new LoggerService();

List<User> users = new List<User>()
{
    new User("Bob", "bob123"),
    new User("Jill", "jill123"),
    new User("Greg", "greg123")
};

try
{
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();

    Login(username, password);
    Console.ReadKey();
}
catch(InvalidLoginException ex)
{
    Console.WriteLine($"[ERROR] {ex.Message}");
    Console.WriteLine("Check your username and password and try again!");
    logger.Log(ex.GetType().Name, ex.Message, ex.Username);
}
catch (Exception ex)
{
    Console.WriteLine($"[ERROR] {ex.Message}");
    Console.WriteLine("Please try again or contact support!");
    logger.Log(ex.GetType().Name, ex.Message);
    logger.LogError();
}


void Login(string username, string password)
{
    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        throw new Exception();

    User user = users.FirstOrDefault(x => x.Username == username && x.Password == password);

    if(user == null)
    {
        throw new InvalidLoginException(username);
    }

    Console.WriteLine($"Welcome {username}");
}