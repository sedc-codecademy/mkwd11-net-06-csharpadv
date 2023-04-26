using TaxiManager.DomainModels.Enums;

namespace TaxiManager.DomainModels.Models
{
    public class User : BaseEntity
    {

        public User() { }

        public User(string userName, string password, Role role)
        {
            Username = userName;
            Password = password;
            Role = role;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


        public override string Print()
        {
            return $"{Username} with the role of {Role}";
        }
    }
}
