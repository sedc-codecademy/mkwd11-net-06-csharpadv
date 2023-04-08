using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
    }
}
