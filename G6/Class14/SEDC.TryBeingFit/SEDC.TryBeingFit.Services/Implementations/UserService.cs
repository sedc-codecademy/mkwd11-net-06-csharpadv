using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.DbInterfaces;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        //always make the classes dependent on interface (dependent on signatures)
        //this way we will be able to provide different implementations that implement that interface
        private Domain.Database.IDatabase<T> _database;

        public UserService()
        {
            //we can always assign an object from a class that implements an interface to a variable 
            //with type interface (new Database() -> IDatabase)
            _database = new Domain.Database.IDatabase<T>();
        }
        public T Register(T newObject)
        {
            //1. validate new user data

            //firstName and LastName to have more than 2 characters
            //username to have more than 6 characters
            //password to have more than 6 characters and at least one number

            if (!ValidationHelper.ValidateName(newObject.FirstName))
            {
                throw new Exception("Invalid first name value");
            }

            if (!ValidationHelper.ValidateName(newObject.LastName))
            {
                throw new Exception("Invalid last name value");
            }

            if (!ValidationHelper.ValidateUsername(newObject.Username))
            {
                throw new Exception("Invalid userName value");
            }

            if (!ValidationHelper.ValidatePassword(newObject.Password))
            {
                throw new Exception("Invalid password value");
            }


            //2. insert into the db
            int newId = _database.Add(newObject);

            //3. return the newly added user from the db
            T newUser = _database.GetById(newId);
            return newUser;
        }

        public List<T> GetAll()
        {
            List<T> items =  _database.GetAll();
            return items;
        }

        public T Login(string username, string password)
        {
            //1. search through all users for a user with the given username and password

            //1.1 get all users from db
            List<T> allUsers = _database.GetAll();
            //1.2 search
            T userDb = allUsers.FirstOrDefault(x => x.Username == username && x.Password == password);

            if(userDb == null)
            {
                throw new Exception("Wrong username or password");
            }

            return userDb;
        }

        public T ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T userDb = _database.GetById(userId);
            if (userDb.Password != oldPassword)
            {
                throw new Exception("Old passwords do not match");
            }
            if (!ValidationHelper.ValidatePassword(newPassword))
            {
                throw new Exception("Invalid password");
            }
            userDb.Password = newPassword;
            //send the object with the new values to the Update method of the database
            _database.Update(userDb);

            return userDb;
        }

        public T ChangeInfo(int userId, string firstName, string lastName)
        {
            T userDb = _database.GetById(userId);
            if(userDb == null)
            {
                throw new Exception($"User with id {userId} was not found in db");
            }

            if (!ValidationHelper.ValidateName(firstName) || !ValidationHelper.ValidateName(lastName))
            {
                throw new Exception("Invalid firstName or lastName");
            }

            userDb.FirstName = firstName;
            userDb.LastName = lastName;
            _database.Update(userDb);

            return userDb;
        }

        public void RemoveById(int userId)
        {
            //it is a good practise to first check if there is a record with this id in the db
            //the app receives multiple requests at the same time and maybe someone already deleted the record
            T userDb = _database.GetById(userId);
            if (userDb == null)
            {
                throw new Exception($"User with id {userId} was not found in db");
            }

            _database.RemoveById(userId);
        }
    }
}
