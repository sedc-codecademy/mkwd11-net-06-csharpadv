using TaxiManager.DomainModels.Models;

namespace TaxiManager.Services.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void Login(string username, string password);
        bool ChangePassword(string oldPassword, string newPassword);
    }
}
