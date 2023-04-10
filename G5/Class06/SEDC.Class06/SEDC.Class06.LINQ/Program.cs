using SEDC.Class06.Domain.Entities;
using SEDC.Class06.Domain.Enums;
using SEDC.Class06.LINQ.Helpers;


// LINQ -> Language Integrated Query

Console.WriteLine("=== Where ===");

// Lambda Syntax
List<Student> findBobLambda = AcademyDatabase.Students.Where(student => student.FirstName == "Bob").ToList();
findBobLambda.PrintEntities();


// SQL Syntax
List<Student> findBobSql = (from student in AcademyDatabase.Students
                            where student.FirstName == "Bob"
                            select student).ToList();

findBobSql.PrintEntities();

Console.WriteLine("=== Select ===");

// Lambda Syntax
List<string> studentFirstNamesLambda = AcademyDatabase.Students
                                       .Select(student => student.FirstName)
                                       .ToList();
studentFirstNamesLambda.PrintSimple();


List<string> studentFullNamesLambda = AcademyDatabase.Students
                                      .Select(student => $"{student.FirstName} {student.LastName}")
                                      .ToList();
studentFullNamesLambda.PrintSimple();


// SQL Syntax
List<string> studentFirstNamesSql = (from student in AcademyDatabase.Students
                                     select student.FirstName).ToList();
studentFirstNamesSql.PrintSimple();


List<string> studentFullNamesSql = (from student in AcademyDatabase.Students
                                    select $"{student.FirstName} {student.LastName}").ToList();
studentFullNamesSql.PrintSimple();


Console.WriteLine("=== Complex Query ===");

var partTimeProgrammingStudentsLambda =
    AcademyDatabase.Students
    .Where(std => std.IsPartTime)
    .Where(std => std.Subjects.Where(sub => sub.Type == Academy.Programming).ToList().Count != 0)
    .ToList();

partTimeProgrammingStudentsLambda.PrintEntities();
