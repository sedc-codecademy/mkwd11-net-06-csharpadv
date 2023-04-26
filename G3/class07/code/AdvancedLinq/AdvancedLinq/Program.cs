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


List<string> emptyListOfString = new List<string>();
List<int> emptyListOfNums = new List<int>();
List<Student> emptyListOfStudents = new List<Student>();

// First/FristOrDefault Last/LastOrDefault Single/SingleOrDefault
Console.WriteLine("First/FristOrDefault Last/LastOrDefault Single/SingleOrDefault");

// First => Gets first element, if no elements it will throw error
// FirstOrDefault => Gets first element, if no elements will return default and will not throw error

// Last => Gets last element, if no elements it will throw error
// LastOrDefault => Gets last element, if no elements will return default and will not throw error

// Single => Gets the only element from list, if more than one elements or no elements will throw error
// SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

var firstStudent = SEDC.Students.First();
Console.WriteLine(firstStudent.Info());

//var firstStudentEmpty = emptyListOfStudents.First();
var firstOrDefaultStudentEmpty = emptyListOfStudents.FirstOrDefault();

var lastStudent = SEDC.Students.Last();
//var lastOrDefaultStudent = emptyListOfStudents.LastOrDefault();

//SEDC.Students.Single(student => student.Age > 30);
var result = emptyListOfStudents.SingleOrDefault(student => student.Age > 30);

// SelectMany
Console.WriteLine("Selectmany");

//select
// Issue because it does not give all the results in one list, but creates a list of lists
List<List<Subject>> partTimeSubjectSelect = SEDC.Students
    .Where(student => student.IsPartTime)
    .Select(student => student.Subjects)
    .ToList();

//select many
// Flatens all the lists in to one list
List<Subject> partTimeSubjectsSelectMany = SEDC.Students
    .Where(student => student.IsPartTime)
    .SelectMany(student => student.Subjects)
    .ToList();

//disticnt
// Removes all the duplicates from one list
List<Subject> disctinctSubjects = partTimeSubjectsSelectMany.Distinct().ToList();

//Any
bool isBob = SEDC.Students.Any(student => student.FirstName == "Bob");
bool isDragan = SEDC.Students.Any(student => student.FirstName == "Dragan");

//All
bool areThereShortNames = SEDC.Students.All(student => student.FirstName.Length >= 3);
bool areThereLongNames = SEDC.Students.All(student => student.FirstName.Length >= 4);

//Except
List<Student> exeptPartTime = SEDC.Students.Except(SEDC.Students.Where(st => st.IsPartTime)).ToList();

exeptPartTime.PrintEntites();

// ORDERBY / ORDERBYDESCENDING / THENBY / THENBYDESCENDING

List<Student> sortedStudents = SEDC.Students
    .OrderBy(student => student.FirstName).ToList();

sortedStudents.PrintEntites();

List<Student> sortedStudentsDesc = SEDC.Students
    .OrderByDescending(student => student.FirstName).ToList();

sortedStudentsDesc.PrintEntites();

List<Student> sortStudentsThen = SEDC.Students
    .OrderBy(student => student.FirstName)
    .ThenBy(student => student.Age)
    .ToList();

sortStudentsThen.PrintEntites();
