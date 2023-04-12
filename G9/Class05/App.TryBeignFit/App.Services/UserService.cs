using App.Domain.Infrastructure;
using App.Domain.Models;
using App.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class UserService<T> : IUserService<T> where T : User
    {
        public IDatabase<T> _database = new Database<T> { };
        public T Login(T user)
        {
            if(_database.GetAll().FirstOrDefault
                (x=>x.UserName==user.UserName 
                && x.Password == user.Password)!=null)
                {
                return user;
            }
            else
            {
                return null;
            }
        }

        public T Register(T user)
        {
            if(Validators.ValidateFirstName(user.FirstName)
                && Validators.ValidateUsername(user.UserName)
                && Validators.ValidatePassword(user.Password))
            {
                _database.Insert(user);
                return user;
            }
            else
            {
                return null;
            }
        }

        public T StandardToPremium(T user)
        {
            user.Role = Domain.Role.PremiumUser;
            _database.Update(user);
            return user;
        }
    }
}
