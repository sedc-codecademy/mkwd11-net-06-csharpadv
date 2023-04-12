using SEDC.Class06.LINQ.Entities;
using SEDC.Class06.LINQ.Helpers;
using SEDC.LINQ;


var studentList = SEDC.LINQ.SEDC.Students;
Console.WriteLine("START LINQ Advanced");

Console.WriteLine("WHERE with LINQ");

// WHERE - Select all students that has first name Bob
IEnumerable<Student> bobStudentsLinq = studentList.Where(x => x.FirstName.ToLower() == "bob");
bobStudentsLinq.ToList().PrintEntities();


Console.WriteLine("WHERE LINQ to SQL");
IEnumerable<Student> bobStudentsSql = from student in studentList
                                      where student.FirstName.ToLower() == "bob"
                                      select student;



// SELECT - Select all first names from students 
List<string> firstNamesLinq = studentList.Select(student => student.FirstName).ToList();
firstNamesLinq.PrintSimple();

List<string> firstNamesSql = (from student in studentList
                              select student.FirstName).ToList();
firstNamesSql.PrintSimple();

// SELECT - Select all full names from students 
List<string> fullNamesSql = (from student in studentList
                             select $"{student.FirstName} {student.LastName}"
                             ).ToList();
fullNamesSql.PrintSimple();



// COMPLEX Queries - Select all students that are part time students and belong to the Programming academy


List<Student> ptStudentsLinq = studentList.Where(st => st.IsPartTime)
                                          .Where(st => st.Subjects.Where(sub => sub.Type == Academy.Programming)
                                          .ToList().Count != 0).ToList();
ptStudentsLinq.PrintEntities();


List<Student> ptStudentsSql = (from student in studentList
                               where student.IsPartTime
                               where (from subject in student.Subjects
                                      where subject.Type == Academy.Programming
                                      select subject
                                      ).ToList().Count != 0
                               select student
                               ).ToList();


// Represent the previous query with for loop

//foreach (var student in studentList)
//{
//    if (student.IsPartTime)
//    {
//        foreach (var subject in student.Subjects)
//        {
//            if(subject.Type == Academy.Programming)
//            {

//            }
//        }
//    }
//}



var allSubjectsForPtStudents = studentList.Where(st => st.IsPartTime)
                                          .Select(st => st.Subjects).ToList();

foreach (var item in allSubjectsForPtStudents)
{
    foreach (var sub in item)
    {
        Console.WriteLine(sub.Title);
    }
}

List<Subject> allSubjectsForPtStudentsListOnly = studentList.Where(st => st.IsPartTime)
                                                            .SelectMany(st => st.Subjects).Distinct().ToList();

allSubjectsForPtStudentsListOnly.PrintEntities();