using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public User? CurrentUser { get; set; }

        public void Login(string username, string password)
        {
            CurrentUser = _db.GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);
            if (CurrentUser == null)
            {
                throw new Exception("Login unsuccessful. Please try again");
            }
        }

        public bool ChangePassword(int id, string oldPassword, string newPassword)
        {
            var user = _db.GetById(id);
            if (user.Password == oldPassword)
            {
                user.Password = newPassword;
                return true;
            }
            else
            {
                Console.WriteLine("Incorect old password inserted");
                return false;
            }
        }

        public List<User> GetUsersForRemoval()
        {
            return _db.GetAll().Where(x => x != CurrentUser).ToList();
        }
    }
}
