using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        T Register(T newUser);
        List<T> GetAll();

        T Login(string username, string password);

        T ChangePassword(int userId, string oldPassword, string newPassword);

        T ChangeInfo(int userId, string firstName, string lastName);

        void RemoveById(int userId);

    }
}
