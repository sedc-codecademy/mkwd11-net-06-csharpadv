using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;
using TaxiManagerApp9000.Services;

UserService userService = new UserService();

User user1 = new User("admin", "admin", Role.Administrator);
User user2 = new User("manager", "manager", Role.Manager);

userService.Add(user1);
userService.Add(user2);

Console.WriteLine("All users in the system");
userService.GetAll().ForEach(x => Console.WriteLine($"{x.Username} - {x.Role.ToString()}"));

Console.WriteLine("==============================");
Console.WriteLine("Login user admin:");
var user = userService.Login("admin", "admin");
if (user == null)
{
    Console.WriteLine("Login failed");
}
else
{
    Console.WriteLine("Login OK");
}