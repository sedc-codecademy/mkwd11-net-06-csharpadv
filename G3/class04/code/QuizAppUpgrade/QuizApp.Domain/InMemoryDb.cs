using QuizApp.Domain.Models;

namespace QuizApp.Domain
{
    public static class InMemoryDb
    {
        public static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher 
            {
                Firstname = "Viktor",
                Lastname = "Jakovlev",
                Username = "vjakovlev",
                Password = "123"
            },
            new Teacher
            {
                Firstname = "Dragan",
                Lastname = "Manaskov",
                Username = "dmanaskov",
                Password = "123"
            },
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student 
            {
                Firstname = "Student1",
                Lastname = "Student1LastName",
                Username = "student1",
                Password = "123",
                HasFinishedQuiz = false
            },
            new Student
            {
                Firstname = "Student2",
                Lastname = "Student2LastName",
                Username = "student2",
                Password = "123",
                HasFinishedQuiz = false
            },
            new Student
            {
                Firstname = "Student3",
                Lastname = "Student3LastName",
                Username = "student3",
                Password = "123",
                HasFinishedQuiz = false
            },
            new Student
            {
                Firstname = "Student4",
                Lastname = "Student4LastName",
                Username = "student4",
                Password = "123",
                HasFinishedQuiz = false
            },
        };

        public static List<Question> Questions = new List<Question>()
        {
            new Question 
            {
                Description = "What is the capital of Tasmania?",
                Answers = new List<string> 
                {
                    "Dodoma",
                    "Hobart",
                    "Launceston",
                    "Wellington"
                },
                CorrectAnswer = 2
            },
            new Question
            {
                Description = "What is the tallest building in the Republic of the Congo?",
                Answers = new List<string>
                {
                    "Kinshasa Democratic Republic of the Congo Temple",
                    "Palais de la Nation",
                    "Kongo Trade Centre",
                    "Nabemba Tower"
                },
                CorrectAnswer = 4
            },
            new Question
            {
                Description = "Which of these is not one of Pluto's moons?",
                Answers = new List<string>
                {
                    "Styx",
                    "Hydra",
                    "Nix",
                    "Lugia"
                },
                CorrectAnswer = 3
            },
            new Question
            {
                Description = "What is the smallest lake in the world?",
                Answers = new List<string>
                {
                    "Onega Lake",
                    "Benxi Lake",
                    "Kivu Lake",
                    "Wakatipu Lake"
                },
                CorrectAnswer = 2
            },
            new Question
            {
                Description = "What country has the largest population of alpacas?",
                Answers = new List<string>
                {
                    "Chad",
                    "Peru",
                    "Australia",
                    "Niger"
                },
                CorrectAnswer = 2
            },
        };
    }
}
