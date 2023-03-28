using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class AcademyMember
    {
        public AcademyMember(string userName, string firstName, string lastName, int age)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string UserName { get; set; } // Unique
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }

    }
}
