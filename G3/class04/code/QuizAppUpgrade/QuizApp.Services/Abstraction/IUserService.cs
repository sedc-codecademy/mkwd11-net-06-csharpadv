using QuizApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Services.Abstraction
{
    public interface IUserService
    {
        Student GetStudentByUsername(string username);
        Teacher GetTeacherByUserName(string username);
        List<Student> GetStudentsThatDidTheQuiz();
        List<Student> GetStudentThatDidNotFinishTheQuiz();
        bool PasswordMatch(string password);
    }
}
