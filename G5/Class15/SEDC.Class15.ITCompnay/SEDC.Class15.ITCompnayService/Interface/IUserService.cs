using SEDC.Class15.ITCompnay.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompnayService.Interface
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeFirstName(int userId, string newFirstName);
        void AddUser(T user);
        void GetAllUser();
    }
}
