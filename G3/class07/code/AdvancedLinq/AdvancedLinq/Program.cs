using AdvancedLinq.Entities;
using AdvancedLinq.Helpers;

//ADVANCED LINQ

// WHERE
Console.WriteLine("WHERE");

//Lambda

IEnumerable<Student> findBobLambda = SEDC.Students
    .Where(student => student.FirstName == "Bob");

findBobLambda.ToList().PrintEntites();

//SQLlike

IEnumerable<Student> findBobSql = from student in SEDC.Students
                                  where student.FirstName == "Bob"
                                  select student;

findBobSql.ToList().PrintEntites();

// SELECT
Console.WriteLine("SELECT");

//Lambda

IEnumerable<string> firstNameLambda = SEDC.Students
    .Select(student => student.FirstName);

IEnumerable<string> fullNameLambda = SEDC.Students
    .Select(student => $"{student.FirstName} {student.LastName}");

firstNameLambda.ToList().PrintSimple();
fullNameLambda.ToList().PrintSimple();

//SQLlike

IEnumerable<string> firstNameSql = from student in SEDC.Students
                                   select student.FirstName;

List<string> fullNameSql = (from student in SEDC.Students
                           select $"{student.FirstName} {student.LastName}")
                           .ToList();

firstNameSql.ToList().PrintSimple();
fullNameSql.PrintSimple();