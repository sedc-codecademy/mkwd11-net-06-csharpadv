using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Linq;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDatabase<T> _database;
        public UserService()
        {
            //_database = new Database<T>(); //in memory db (list)
            _database = new FileDatabase<T>();
        }

        public T ChangeInfo(int userId, string firstName, string lastName)
        {
            T userDb = GetById(userId);
            if(!ValidationHelper.ValidateName(firstName) || !ValidationHelper.ValidateName(lastName))
            {
                MessageHelper.PrintMessage("[Error] Invalid user data", ConsoleColor.Red);
                return null;
            }
            userDb.FirstName = firstName;
            userDb.LastName = lastName;
            _database.Update(userDb);
            MessageHelper.PrintMessage($"User with id {userId} was successfully updated", ConsoleColor.Green);
            return _database.GetbyId(userId);
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

        public T GetById(int id)
        {
            return _database.GetbyId(id);
        }

        public T LogIn(string username, string password)
        {
            T userDb = _database.GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);
            if(userDb == null)
            {
                MessageHelper.PrintMessage($"[Error] User with username {username} does not exist.", ConsoleColor.Red);
                return null;
            }
            return userDb;
        }

        public T Register(T userModel)
        {
            if(!ValidationHelper.ValidateName(userModel.FirstName) || !ValidationHelper.ValidateName(userModel.LastName)
                || !ValidationHelper.ValidateUsername(userModel.Username) || !ValidationHelper.ValidatePassword(userModel.Password))
            {
                MessageHelper.PrintMessage("[Error] User data is invalid", ConsoleColor.Red);
                return null;
            }
            int id = _database.Insert(userModel);
            return _database.GetbyId(id);
        }

        public void RemoveById(int id)
        {
            _database.RemoveById(id);
        }
    }
}
