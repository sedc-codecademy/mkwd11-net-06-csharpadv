using TryBeingFit.Models;

namespace TryBeingFit.Services.Interface
{
    public interface IUserService
    {
        StandardUser Register(string firstName, string lastName, string username, string password, string email, string phone);
        User Login(string username, string password);
        bool ChangePassword(string username, string oldPassword, string newPassword);
        PremiumUser UpgradeUser(int userId);
    }
}
