using SEDC.TryBeingFit.Domain.Enums;

namespace SEDC.TryBeingFit.Domain.Models
{
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
