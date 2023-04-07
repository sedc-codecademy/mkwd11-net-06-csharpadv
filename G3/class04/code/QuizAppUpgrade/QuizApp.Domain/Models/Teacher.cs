using QuizApp.Domain.Enums;

namespace QuizApp.Domain.Models
{
    public class Teacher : User
    {
        public Teacher()
        {
            Role = Role.Teacher;
        }
    }
}
