using FileSystemDatabase;
using FileSystemDatabase.Models;

Db<Student> studentsDb = new Db<Student>();
Db<Subject> subjectsDb = new Db<Subject>();

void Seed()
{
    if (studentsDb.GetAll().Count == 0)
    {
        Console.WriteLine("====Inserting Students====");
        studentsDb.Insert(new Student("Bob", "Bobsky", 25));
        studentsDb.Insert(new Student("Jill", "Wayne", 29));
        studentsDb.Insert(new Student("Greg", "Gregsky", 36));
    }

    if (subjectsDb.GetAll().Count == 0) 
    {
        Console.WriteLine("====Inserting Subjects====");
        subjectsDb.Insert(new Subject("C# Advanced", 15, Academy.Code));
        subjectsDb.Insert(new Subject("Introduction to servers", 32, Academy.Networks));
        subjectsDb.Insert(new Subject("Photoshop", 60, Academy.Design));
    }
}
Seed();

//check if GetAll() works
List<Student> Students = studentsDb.GetAll();
List<Subject> Subjects = subjectsDb.GetAll();

foreach (var student in Students)
{
    Console.WriteLine(student.Info());
}

foreach (var subject in Subjects)
{
    Console.WriteLine(subject.Info());
}

//check if GetById() works

var st = studentsDb.GetById(2);
var su = subjectsDb.GetById(1);

Console.WriteLine(st);
Console.WriteLine(su);

// check if Insert() works

var newStudent = new Student("Dragan", "Manaskov", 21);
//var newStudentId = studentsDb.Insert(newStudent);

//Console.WriteLine($"Student with id: {newStudentId} was insert in the database!");

//foreach (var student in studentsDb.GetAll())
//{
//    Console.WriteLine(student.Info());
//}

// check if Delete() works

studentsDb.Delete(1);

var test = studentsDb.GetAll();

Console.WriteLine("=======");

foreach (var student in studentsDb.GetAll())
{
    Console.WriteLine(student.Info());
}




studentsDb.ClearDb();


Console.ReadLine();


