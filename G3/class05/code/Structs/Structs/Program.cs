string name = "Viktor";
int age = 33;

User2 user = new User2()
{
    Username = "Petar",
    Pin = 123
};

void DoSomething(string n, int a, User2 u) 
{
    n = "Dragan";
    a = 22;
    u.Username = "Igor";
    u.Pin = 321;
}

Console.WriteLine("BEFORE calling the DoSomething()");
Console.WriteLine("========");

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(user.Username);
Console.WriteLine(user.Pin);


DoSomething(name, age, user);

Console.WriteLine("AFTER calling the DoSomething()");
Console.WriteLine("========");

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(user.Username);
Console.WriteLine(user.Pin);

Console.ReadLine();


class User 
{
    public string Username { get; set; }
    public int Pin { get; set; }
}

struct User2
{
    public string Username { get; set; }
    public int Pin { get; set; }
}