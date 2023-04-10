using QuizApp.Domain;
using QuizApp.Domain.Models;
using QuizApp.Services.Abstraction;

namespace QuizApp.Services
{
    public class UserService : IUserService
    {
        public Student GetStudentByUsername(string username) 
        {
            return InMemoryDb.Students.FirstOrDefault(student =>
                student.Username.ToLower() == username.ToLower());
        }

        public Teacher GetTeacherByUserName(string username) 
        {
            return InMemoryDb.Teachers.FirstOrDefault(teacher =>
                teacher.Username.ToLower() == username.ToLower());
        }

        public List<Student> GetStudentsThatDidTheQuiz() 
        {
            return InMemoryDb.Students.Where(student =>
                student.HasFinishedQuiz).ToList();
        }

        public List<Student> GetStudentThatDidNotFinishTheQuiz() 
        {
            return InMemoryDb.Students.Where(student =>
                !student.HasFinishedQuiz).ToList();
        }

        public bool PasswordMatch(string password) 
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter password:");
                string passwordInput = Console.ReadLine();

                if (password == passwordInput) 
                {
                    return true;
                }
            }

            return false;
        }

    }
}
