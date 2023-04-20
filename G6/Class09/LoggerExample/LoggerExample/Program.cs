using LoggerExample;

LoggerService loggerService = new LoggerService();

List<User> users = new List<User>
{
    new User{Id = 1, FirstName = "Bob", LastName = "Bobsky", Username = "bbobsky", Password = "123"},
    new User{Id = 2, FirstName = "Ana", LastName = "Petrovska", Username = "apetrovska", Password = "424"}
};

void Login(string username, string password)
{
    User user = users.FirstOrDefault(x => x.Username == username && x.Password == password);
    if(user == null)
    {
        throw new Exception($"Invalid login for {username}");
    }
}


try
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    loggerService.Log($"Trying to log in a user with username {username}", false);

    Login(username, password);
}
catch(Exception e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);

    loggerService.Log(e.Message, true);
}
