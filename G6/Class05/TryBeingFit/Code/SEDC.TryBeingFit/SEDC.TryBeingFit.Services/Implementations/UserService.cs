using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;
using System;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDatabase<T> _database;
        public UserService()
        {
            _database = new Database<T>();
        }
        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T userDb = _database.GetbyId(userId);
            if(userDb.Password != oldPassword)
            {
                throw new Exception("Old passwords do not match");
            }
            if(!ValidationHelper.ValidatePassword(newPassword))
            {
                throw new Exception("Invalid password");
            }
            userDb.Password = newPassword;
            //send the object with the new values to the Update method of the database
            _database.Update(userDb);
        }
    }
}
