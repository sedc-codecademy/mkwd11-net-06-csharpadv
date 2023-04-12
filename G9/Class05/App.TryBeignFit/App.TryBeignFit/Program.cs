// choose menu
// register 

using App.Domain.Models;
using App.Services;

Console.WriteLine("Insert first name");
var firstName = Console.ReadLine();
Console.WriteLine("Insert lsat name");
var lastName =Console.ReadLine();
Console.WriteLine("Insert username name");
var username = Console.ReadLine();
Console.WriteLine("Insert pasword name");
var password =Console.ReadLine();

var userService = new UserService<StandardUser> { };
userService.Register(
    new StandardUser
    {
        FirstName = firstName,
        LastName = lastName,
        UserName = username,
        Password = password
    }
    );

