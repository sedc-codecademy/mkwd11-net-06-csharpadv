using SEDC.Class15.ITCompany.DataAccess.Implementations;
using SEDC.Class15.ITCompany.DataAccess.Interface;
using SEDC.Class15.ITCompnay.Domain.Models;
using SEDC.Class15.ITCompnayService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompnayService.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDataBase<T> _dataBase= new DataBase<T>();

        public UserService()
        {

        }
        public void AddUser(T user)
        {
            _dataBase.Insert(user);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successful insert user");
            Console.ResetColor();
        }

        public void ChangeFirstName(int userId, string newFirstName)
        {
            T userDb = _dataBase.GetById(userId);

            userDb.FirstName = newFirstName;
            _dataBase.Update(userDb);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successful update first name");
            Console.ResetColor();
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T userDb = _dataBase.GetById(userId);

            userDb.Password = newPassword;
            _dataBase.Update(userDb);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successful update password");
            Console.ResetColor();
        }

        public void GetAllUser()
        {
            List<T> allUser = _dataBase.GetAll();
            foreach(T user in allUser)
            {
                Console.WriteLine("====");
                Console.WriteLine(user.GetInfo());
            }
        }
    }
}
