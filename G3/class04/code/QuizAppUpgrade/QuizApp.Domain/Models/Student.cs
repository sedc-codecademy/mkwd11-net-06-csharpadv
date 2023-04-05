using QuizApp.Domain.Enums;

namespace QuizApp.Domain.Models
{
    public class Student : User
    {
        public bool HasFinishedQuiz { get; set; }
        public int CorrectAnswers { get; set; }

        public Student()
        {
            Role = Role.Student;
        }
    }
}
