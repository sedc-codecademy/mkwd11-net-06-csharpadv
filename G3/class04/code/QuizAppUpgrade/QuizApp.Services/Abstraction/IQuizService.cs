using QuizApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Services.Abstraction
{
    public interface IQuizService
    {
        void TakeQuiz(Student student);
    }
}
