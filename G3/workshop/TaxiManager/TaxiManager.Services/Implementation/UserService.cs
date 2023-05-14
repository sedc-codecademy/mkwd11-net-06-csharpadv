using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Abstraction;

namespace TaxiManager.Services.Implementation
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public void Login(string username, string password)
        {
            CurrentUser = _db.GetAll().SingleOrDefault(user 
                => user.Username == username.ToLower() && user.Password == password);

            if (CurrentUser == null) 
            {
                throw new Exception("Login failed, please try again...");
            }

        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            User user = _db.GetById(CurrentUser.Id);

            if (user.Password != oldPassword) 
            {
                return false;
            }

            user.Password = newPassword;
            _db.Update(user);
            return true;
        }  
    }
}
