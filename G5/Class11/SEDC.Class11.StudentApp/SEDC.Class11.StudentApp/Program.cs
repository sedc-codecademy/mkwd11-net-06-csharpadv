using SEDC.Class11.StudentApp.Domain;
using SEDC.Class11.StudentApp.Domain.Models;

Database<Student> dbStudent = new Database<Student>();
Database<Subject> dbSubject = new Database<Subject>();

Console.WriteLine("========== All Subject ==========");

List<Subject> allSubjects = dbSubject.GetAll();

foreach(Subject subject in allSubjects)
{
    Console.WriteLine(subject.GetInfo());
}

Console.WriteLine("========== All Student ==========");
List<Student> allStudents = dbStudent.GetAll();

foreach (Student student in allStudents)
{
    Console.WriteLine(student.GetInfo());
}


Console.WriteLine("========== Insert Subject ==========");

Subject subject1 = new Subject()
{
    Title = "Basic JS",
    Description = "Basic JS",
    NumberOfModules = 10
};

//dbSubject.Insert(subject1);


Console.WriteLine("========== Insert Student ==========");

Student student1 = new Student()
{
    FirstName = "Dragisha",
    LastName = "Todoroski",
    Age = 24,
    IsLazy = true
};

//dbStudent.Insert(student1);

Console.WriteLine("========== Get by ID Subject ==========");

//Subject subjectById = dbSubject.GetById(9);

Subject subjectById = dbSubject.GetById(1);

if(subjectById == null)
{
    Console.WriteLine($"Subject with id does not exist");
}
else
{
    Console.WriteLine(subjectById.GetInfo());
}


Console.WriteLine("========== Get by ID Student ==========");


//Student studentById = dbStudent.GetById(1);
Student studentById = dbStudent.GetById(12);

if (studentById == null)
{
    Console.WriteLine($"Student with id does not exist");
}
else
{
    Console.WriteLine(studentById.GetInfo());
}