using QuizApp.Domain;
using QuizApp.Domain.Models;
using QuizApp.Services.Abstraction;

namespace QuizApp.Services
{
    public class QuizService : IQuizService
    {
        public void TakeQuiz(Student student) 
        {
            foreach (Question question in InMemoryDb.Questions) 
            {
                Console.WriteLine(question.Description);

                for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                }

                bool isAnswered = false;
                while (!isAnswered) 
                {
                    Console.WriteLine("Enter answer: ");
                    bool sucess = int.TryParse(Console.ReadLine(), out int selection);

                    if (!sucess)
                    {
                        Console.WriteLine("You must enter a number.");
                        continue;
                    }

                    if (selection < 1 || selection > question.Answers.Count)
                    {
                        Console.WriteLine("Invalid selction.");
                        continue;
                    }

                    if (question.CorrectAnswer == selection)
                    {
                        student.CorrectAnswers++;
                    }

                    isAnswered = true;
                }
            }
        
            student.HasFinishedQuiz = true;
            Console.WriteLine("Thank you!.");
        }
    }
}
