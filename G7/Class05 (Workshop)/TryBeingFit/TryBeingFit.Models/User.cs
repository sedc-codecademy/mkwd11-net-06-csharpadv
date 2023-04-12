using TryBeingFit.Models.Enums;

namespace TryBeingFit.Models
{
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Username { get; set; }
        protected string Password { get; set; }
        public UserRole UserRole { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        protected User(string firstName, string lastName, string username, string password, UserRole userRole, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            UserRole = userRole;
            Email = email;
            Phone = phone;
        }
    }
}
