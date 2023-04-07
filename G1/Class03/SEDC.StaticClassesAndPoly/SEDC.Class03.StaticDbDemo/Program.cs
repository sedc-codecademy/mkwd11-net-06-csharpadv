using SEDC.Class03.StaticDbDemo.Entities;
using SEDC.Class03.StaticDbDemo.InMemoryDb;


StaticDb.PrintAllUsers();
Console.WriteLine("==============");
StaticDb.PrintAllOrders();


Console.WriteLine("Choose 1 for add new user or 2 for add new order");
string userInput = Console.ReadLine(); 

if(userInput == "1")
{
    Console.WriteLine("Please enter Name");
    string input = Console.ReadLine();
    int id = ++StaticDb.UserId;

    User user = new User() { Id = id, Name = input, Orders = new List<Order>() };
    StaticDb.AddNewUser(user);
    StaticDb.PrintAllUsers();
}
else if(userInput == "2")
{

}
else
{
    Console.WriteLine("Wrong input!");
}
