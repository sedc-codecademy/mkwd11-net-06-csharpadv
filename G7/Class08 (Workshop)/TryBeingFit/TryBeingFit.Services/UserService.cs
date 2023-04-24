using System.Net.Http.Headers;
using TryBeingFit.Models;
using TryBeingFit.Models.Database;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interface;

namespace TryBeingFit.Services
{
    public class UserService : IUserService
    {
        private IDatabase<User> _userDatabase;

        public UserService(IDatabase<User> database)
        {
            _userDatabase = database;
        }

        public StandardUser Register(string firstName, string lastName, string username, string password, string email, string phone)
        {
            if (string.IsNullOrEmpty(firstName) || firstName.Length < 2)
            {
                throw new ArgumentException("Invalid data for first name");
            }

            if (string.IsNullOrEmpty(lastName) || lastName.Length < 2)
            {
                throw new ArgumentException("Invalid data for last name");
            }

            if (string.IsNullOrEmpty(username) || username.Length < 3)
            {
                throw new ArgumentException("Invalid data for username");
            }

            if (!ValidationHelper.ValidPassword(password))
            {
                throw new ArgumentException("Invalid password");
            }

            if (!email.Contains("@"))
            {
                throw new ArgumentException("Invalid email");
            }

            //x.Username.ToLower() == username.ToLower()
            if (_userDatabase.GetAll().Any(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase)))
            {
                throw new Exception("User with that username exists");
            }

            StandardUser u = new StandardUser(firstName, lastName, username, password, email, phone);

            _userDatabase.Insert(u);

            return u;
        }

        public User Login(string username, string password)
        {
            User u = _userDatabase.GetAll().FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase) && x.PasswordMatch(password));

            if (u == null)
            {
                throw new Exception("Username or password is incorect");
            }

            return u;
        }


        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            User u = _userDatabase.GetAll().FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase) && x.PasswordMatch(oldPassword));

            if (u == null)
            {
                throw new Exception("User not found");
            }

            if (!ValidationHelper.ValidPassword(newPassword))
            {
                throw new ArgumentException("New password does not meet the requirements");
            }

            u.ChangePassword(newPassword);

            _userDatabase.Update(u);

            return true;
        }

        public PremiumUser UpgradeUser(int userId)
        {
            User u = _userDatabase.GetById(userId);

            if (u.UserRole != Models.Enums.UserRole.Standard)
            {
                throw new Exception("The user cannot be upgraded to Premium");
            }

            StandardUser su = (StandardUser)u;

            PremiumUser p = su.UpgradeToPremiumUser();

            _userDatabase.Update(p);

            return p;
        }
    }
}