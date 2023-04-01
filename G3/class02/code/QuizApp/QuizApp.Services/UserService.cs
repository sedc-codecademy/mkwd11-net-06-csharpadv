using QuizApp.Domain;
using QuizApp.Domain.Models;

namespace QuizApp.Services
{
    public class UserService
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

    }
}
