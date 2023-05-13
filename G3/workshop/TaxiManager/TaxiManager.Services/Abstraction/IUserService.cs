using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.Services.Abstraction
{
    public interface IUserService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void Login(string username, string password);
        bool ChangePassword(string oldPassword, string newPassword);
    }
}
