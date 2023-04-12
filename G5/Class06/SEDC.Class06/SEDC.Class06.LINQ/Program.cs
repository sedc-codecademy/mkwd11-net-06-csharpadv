using SEDC.Class06.Domain.Entities;
using SEDC.Class06.Domain.Enums;
using SEDC.Class06.LINQ.Helpers;


// LINQ -> Language Integrated Query

Console.WriteLine("=== Where ===");

// Lambda Syntax
List<Student> findBobLambda = AcademyDatabase.Students
    .Where(student => student.FirstName == "Bob")
    .ToList();


findBobLambda.PrintEntities();


// SQL Syntax
List<Student> findBobSql = (from student in AcademyDatabase.Students
                            where student.FirstName == "Bob"
                            select student).ToList();

findBobSql.PrintEntities();



// ====================================================================================================


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


// ====================================================================================================


Console.WriteLine("=== Complex Query ===");

// Lambda Syntax
List<Student> partTimeProgrammingStudentsLambda =
    AcademyDatabase.Students
    .Where(std => std.IsPartTime == true)
    .Where(std => std.Subjects.Where(sub => sub.Type == Academy.Programming).ToList().Count != 0)
    .ToList();

List<Student> partTimeProgrammingStudentsLambdaAny =
    AcademyDatabase.Students
    .Where(std => std.IsPartTime == true && std.Subjects.Any(subject => subject.Type == Academy.Programming))
    .ToList();

partTimeProgrammingStudentsLambda.PrintEntities();
partTimeProgrammingStudentsLambdaAny.PrintEntities();

Console.WriteLine();
Console.WriteLine();

// SQL Syntax
List<Student> partTimeProgrammingStudentsSql = (from student in AcademyDatabase.Students
                                      where student.IsPartTime
                                      where (from subject in student.Subjects
                                             where subject.Type == Academy.Programming
                                             select subject).ToList().Count != 0
                                      select student).ToList();


List<Student> partTimeProgrammingStudentsSqlAny = (from student in AcademyDatabase.Students
                                                where student.IsPartTime
                                                where student.Subjects.Any(subject => subject.Type == Academy.Programming)
                                                select student).ToList();


partTimeProgrammingStudentsSql.PrintEntities();
partTimeProgrammingStudentsSqlAny.PrintEntities();

Console.WriteLine();



// ====================================================================================================
// First / Last / Single / OrDefault

// First => Gets first element, if no elements it will throw error
// FirstOrDefault => Gets first element, if no elements will return default and will not throw error
// Last => Gets last element, if no elements it will throw error
// LastOrDefault => Gets last element, if no elements will return default and will not throw error
// Single => Gets the only element from list, if more than one elements or no elements will throw error
// SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

List<string> emptyListOfStrings = new List<string>();
List<Student> emptyListOfStudents = new List<Student>();

// ====================================================================================================


Console.WriteLine("=== First ===");
Console.WriteLine(AcademyDatabase.Students.First().Info());
Console.WriteLine(AcademyDatabase.Students.First(x => x.FirstName == "Jill"));

// [ERROR] No Entity Found!
//Console.WriteLine(emptyListOfStrings.First());


Console.WriteLine("=== FirstOrDefault ===");

// It wont throw error, but it will return null
string firstString = emptyListOfStrings.FirstOrDefault();
Student studentNotFound = AcademyDatabase.Students.FirstOrDefault(x => x.FirstName == "Jill1");

Console.WriteLine(firstString);
Console.WriteLine(studentNotFound);

// [ERROR] It will return null and then it will try to -> null.FirstName
//Console.WriteLine(AcademyDatabase.Students.FirstOrDefault(x => x.FirstName == "Jill1").FirstName);


// ====================================================================================================


Console.WriteLine();
Console.WriteLine("=== Last ===");
Console.WriteLine(AcademyDatabase.Students.Last().Info());
Console.WriteLine(AcademyDatabase.Students.Last(x => x.FirstName == "Anne").Info());

// [ERROR] No last element
//Console.WriteLine(emptyListOfStudents.Last());

Console.WriteLine();
Console.WriteLine("=== LastOrDefault ===");
Console.WriteLine(emptyListOfStudents.LastOrDefault());

// [ERROR] It will return null and then it will try to -> null.Id
//Console.WriteLine(emptyListOfStudents.LastOrDefault().Id);


// ====================================================================================================


Console.WriteLine("=== Single ===");
Console.WriteLine(AcademyDatabase.Students.Single(x => x.FirstName == "Bob").Info());

// [ERROR] No Records Found!
//Console.WriteLine(AcademyDatabase.Students.Single(x => x.FirstName == "Jill1"));

// [ERROR] Multiple Records Found!
//Console.WriteLine(AcademyDatabase.Students.Single(x => x.FirstName == "Anne").Info());


Console.WriteLine("=== SingleOrDefault ===");
Console.WriteLine(AcademyDatabase.Students.SingleOrDefault(x => x.FirstName == "Bob").Info());


// If no entity found it will return null
Console.WriteLine(AcademyDatabase.Students.SingleOrDefault(x => x.FirstName == "Jill1"));

// [ERROR] Multiple Records Found!
//Console.WriteLine(AcademyDatabase.Students.SingleOrDefault(x => x.FirstName == "Anne"));


// ====================================================================================================
// Flattens a Collection of collections
// Returns IEnumerable of the type from all the collections inside the main collection

Console.WriteLine("=== Select Many ===");

// Select Issue - it does not give all the results in one list, but creates a list of lists
List<List<Subject>> partTimeStudentsSubjects = AcademyDatabase.Students
    .Where(x => x.IsPartTime)
    .Select(x => x.Subjects)
    .ToList();

partTimeStudentsSubjects.PrintSimple();

// Select Many Flattens Lists
// It creates one list of subjects instead of list with subject lists
List<Subject> partTimeStudentsSubjectsSelectMany = AcademyDatabase.Students
    .Where(x => x.IsPartTime)
    .SelectMany(x => x.Subjects)
    .ToList();

partTimeStudentsSubjectsSelectMany.PrintEntities();

Console.WriteLine();


// ====================================================================================================


Console.WriteLine("=== Indexing ===");

// The index is called on the List, not on the Linq query
Subject partTimeSubject = AcademyDatabase.Students
    .Where(x => x.IsPartTime)
    .SelectMany(x => x.Subjects)
    .ToList()[0];

Console.WriteLine(partTimeSubject.Info());


// ====================================================================================================
// Removes all duplicate values from a collection
// Returns IEnumerable of the same type as the original collection

Console.WriteLine("=== Distinct ===");

List<Subject> distinctSubjects = partTimeStudentsSubjectsSelectMany.Distinct().ToList();
List<Subject> nonDistinctSubjects = partTimeStudentsSubjectsSelectMany.ToList();

distinctSubjects.PrintEntities();
Console.WriteLine(distinctSubjects.Count);

nonDistinctSubjects.PrintEntities();
Console.WriteLine(nonDistinctSubjects.Count);


// ====================================================================================================
// Checks if there is at least one item in a collection that follows an expression
// Returns true or false depending on the result

Console.WriteLine("=== Any ===");

bool isBobFound = AcademyDatabase.Students.Any(x => x.FirstName == "Bob");
bool isAngelFound = AcademyDatabase.Students.Any(x => x.FirstName == "Angel");


Console.WriteLine($"Is Bob found: {isBobFound}");
Console.WriteLine($"Is Angel found: {isAngelFound}");


// ====================================================================================================
// Checks if all items of a collection follow a particular expression
// Returns true or false depending on the result
Console.WriteLine("=== All ===");

bool areAllFirstnamesLongerThan3 = AcademyDatabase.Students.All(x => x.FirstName.Length >= 3);
bool areAllFirstnamesLongerThan4 = AcademyDatabase.Students.All(x => x.FirstName.Length >= 4);

Console.WriteLine($"Firstnames longer than 3 - {areAllFirstnamesLongerThan3}");
Console.WriteLine($"Firstnames longer than 4 - {areAllFirstnamesLongerThan4}");


// ====================================================================================================
// Creates a new collection that is missing some particular items
// It returns IEnumerable of the same type as the original collection

Console.WriteLine("=== Except ===");

// Inline
List<Student> exceptPartTime = AcademyDatabase.Students
                    .Except(AcademyDatabase.Students.Where(x => x.IsPartTime))
                    .ToList();

exceptPartTime.PrintEntities();

// External List / IEnumerable
IEnumerable<Student> partTimeStudents = AcademyDatabase.Students.Where(x => x.IsPartTime);
List<Student> exceptPartTimeStudents = AcademyDatabase.Students
                    .Except(partTimeStudents)
                    .ToList();

exceptPartTimeStudents.PrintEntities();


// ====================================================================================================
// Orders a collection by a given value
// Can order by ascending - OrderBy and descending - OrderByDescending
// Can have multiple levels of ordering with the ThenBy and ThenByDescending methods
// Returns IEnumerable of the same type as the original collection

Console.WriteLine("=== OrderBy / ThenBy ===");

List<Student> orderedStudents = AcademyDatabase.Students
                                .OrderBy(x => x.FirstName)
                                .ToList();

List<Student> orderedStudentsDesc = AcademyDatabase.Students
                                   .OrderByDescending(x => x.FirstName)
                                   .ToList();

List<Student> orderedStudentsExtended = AcademyDatabase.Students
                                       .OrderByDescending(x => x.FirstName)
                                       .ThenBy(x => x.Age)
                                       .ThenBy(x => x.Id)
                                       .ToList();


Console.WriteLine("Ordered by firstname (Asc): ");
orderedStudents.PrintEntities();


Console.WriteLine("Ordered by firstname (Desc): ");
orderedStudentsDesc.PrintEntities();

Console.WriteLine("Order By / Then By (Desc):");
orderedStudentsExtended.PrintEntities();