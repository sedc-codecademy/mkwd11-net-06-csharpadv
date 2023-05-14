// See https://aka.ms/new-console-template for more information
using SEDC.GetterSetter.Entitites;


try
{
    User user = new User { FullName = "Stojadin Petkovski"};

    Console.WriteLine(user.Age);

    user.Age = 42;
    Console.WriteLine(user.IsOld);

    Console.WriteLine(user.FullName);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
