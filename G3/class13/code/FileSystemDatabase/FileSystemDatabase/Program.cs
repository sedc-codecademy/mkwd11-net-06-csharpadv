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
