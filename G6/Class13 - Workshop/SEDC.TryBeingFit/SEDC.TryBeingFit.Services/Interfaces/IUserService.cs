using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        T LogIn(string username, string password);
        T Register(T userModel);
        T GetById(int id);
        T ChangeInfo(int userId, string firstName, string lastName);
        void RemoveById(int id);
    }
}
