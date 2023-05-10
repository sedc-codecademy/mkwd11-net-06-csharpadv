using SEDC.TryBeingFit.Domain.Enums;

namespace SEDC.TryBeingFit.Domain.Models
{
    //inherit from BaseEntity to get the Id
    //abstract, because we don't expect to have instances from this class, and we do't need an implemntation of GetInfo here
    //that means that GetInfo stays inherited without implementation
    public abstract class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        //TODO implement login
    }
}
