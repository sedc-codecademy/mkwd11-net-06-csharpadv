using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public Role Role { get; set; }

        public User()
        {

        }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public override string Print()
        {
            return $"User with username: [{Username}] and role: [{Role}]";
        }
    }
}
