using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class SecondUserService<T> : IUserService<T> where T : User
    {
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public T Register(T newUser)
        {
            Console.WriteLine("Second implementation of register");
            return newUser;
        }
    }
}
