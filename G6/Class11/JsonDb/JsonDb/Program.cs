using JsonDb;
using JsonDb.Models;

Database<Student> dbStudents = new Database<Student>();
Database<Subject> dbSubjects = new Database<Subject>();

List<Subject> allSubjects = dbSubjects.GetAll();
foreach (Subject subject in allSubjects)
{
    Console.WriteLine(subject.GetInfo());
}

Subject newSubject = new Subject
{
    Title = "SQL",
    Description = "SQL",
    NumberOfModules = 7
};
dbSubjects.Insert(newSubject);

Console.WriteLine("=====================");
allSubjects = dbSubjects.GetAll();
foreach (Subject subject in allSubjects)
{
    Console.WriteLine(subject.GetInfo());
}


//find the student with id 1
Student studentWithIdOne = dbStudents.GetById(1);
if (studentWithIdOne == null)
{
    Console.WriteLine("Student with id 1 does not exist");
}
else
{
    Console.WriteLine(studentWithIdOne.GetInfo());
}


Console.ReadLine();