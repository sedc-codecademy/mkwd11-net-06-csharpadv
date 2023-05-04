using FileSystemDatabase;
using FileSystemDatabase.Entities;

Db<Student> studentDb = new Db<Student>();
Db<Subject> subjectDb = new Db<Subject>();

// Method that insert some initial data in the database
void Seed()
{

    // Check if inserting works
    // If the databases are empty, only then this will insert the initial data
    if (studentDb.GetAll().Count == 0)
    {
        Console.WriteLine("======= INSERTING STUDENTS =======");
        studentDb.Insert(new Student("Bob", "Bobsky", 25));
        studentDb.Insert(new Student("Jill", "Wayne", 29));
        studentDb.Insert(new Student("Greg", "Gregsky", 36));
    }

    if (subjectDb.GetAll().Count == 0)
    {
        Console.WriteLine("======= INSERTING SUBJECTS =======");
        subjectDb.Insert(new Subject("C# Basic", Academy.Code, 40));
        subjectDb.Insert(new Subject("Introduction to Servers", Academy.Networks, 32));
        subjectDb.Insert(new Subject("Photoshop", Academy.Design, 60));
    }
}

Seed();
Console.WriteLine("======= TESTING =======");
// Check if GetAll work
List<Student> students = studentDb.GetAll();
List<Subject> subjects = subjectDb.GetAll();

Console.WriteLine("======= GET ALL =======");
foreach (Student st in students)
{
    Console.WriteLine(st.Info());
}
foreach (Subject sub in subjects)
{
    Console.WriteLine(sub.Info());
}

Console.WriteLine("======= GET BY ID =======");
// Check if GetById works
Console.WriteLine(studentDb.GetById(2).Info());
Console.WriteLine(subjectDb.GetById(1).Info());
Console.ReadLine();

Console.Clear();
// Insert student by inputs
Console.WriteLine("======= CREATE NEW USER =======");
Console.WriteLine("Enter First Name: ");
string first = Console.ReadLine();
Console.WriteLine("Enter Last Name: ");
string last = Console.ReadLine();
Console.WriteLine("Enter Age: ");
int age = int.Parse(Console.ReadLine());
Student student = new Student(first, last, age);
studentDb.Insert(student);
Console.WriteLine("======= STUDENT CREATED =======");
Console.ReadLine();

Console.WriteLine("======= GET ALL AGAIN =======");
Console.Clear();
foreach (Student st in studentDb.GetAll())
{
    Console.WriteLine(st.Info());
}
Console.ReadLine();

Console.WriteLine("You want to clear both DB? ( y/n )");
string answer = Console.ReadLine();
if (answer.ToLower() == "y")
{
    studentDb.ClearDb();
    subjectDb.ClearDb();
}
else
{
    Console.WriteLine("I guess not. Goodbye!");
}
Console.ReadLine();