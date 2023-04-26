using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.DomainModels.Models;
using TaxiManager.Services.Interfaces;

namespace TaxiManager.Services.Implementations
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            User user = _db.GetById(CurrentUser.Id);
            if (user.Password != oldPassword)
                return false;
            user.Password = newPassword;
            _db.Update(user);
            return true;
        }

        public void Login(string username, string password)
        {
            CurrentUser = _db.GetAll().SingleOrDefault(x => x.Username == username && x.Password == password);
            if (CurrentUser == null)
                throw new Exception("Login failed! Incorrect username or password... Please try again!");
        }
    }
}
