using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        User? CurrentUser { get; set; }

        void Login(string username, string password);

        bool ChangePassword(int id, string oldPassword, string newPassword);

        void Seed(List<User> seedUsers);

        List<User> GetUsersForRemoval();
    }
}
