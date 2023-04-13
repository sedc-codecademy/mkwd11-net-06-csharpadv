using TryBeingFit.Models;
using TryBeingFit.Models.Database;
using TryBeingFit.Services;
using TryBeingFit.Services.Interface;

namespace TryBeingFit.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabase<User> _userDatabase = new Database<User>();
            IUserService _userService = new UserService(_userDatabase);

            //Console input from user
            _userService.Register("Risto", "Panchevski", "ristop", "P@ssw0rd", "risto@gmail.com", "07012345");

            User u = _userService.Login("ristop", "P@ssw0rd");

            _userService.ChangePassword("ristop", "P@ssw0rd", "P@ssw0rd123");

            _userService.UpgradeUser(u.Id);
        }
    }
}