
using AdvancedLINQ;
using AdvancedLINQ.Domain; 
using AdvancedLINQ.Domain.Models;

//students older than 25
List<Student> studentsOlderThan25 = SEDC.Students.Where(x => x.Age > 25).ToList();
studentsOlderThan25.PrintEntities();

//all students named Bob
List<Student> studentsNamedBob = SEDC.Students.Where(x => x.FirstName == "Bob").ToList();
studentsNamedBob.PrintEntities();

var studentsNamedBobSql = from student in SEDC.Students //from all students in list SEDC.Students
                          where student.FirstName == "Bob" //filter out the ones named Bob
                          select student; //take the whole object (record)

//get full names for all students
List<string> fullNames = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
fullNames.PrintSimple();

List<string> fullNamesql = (from student in SEDC.Students
                            select $"{student.FirstName} {student.LastName} ").ToList();

// FIRST / SINGLE / LAST / ORDEFAULT
// First => Gets first element, if no elements it will throw error
// FirstOrDefault => Gets first element, if no elements will return default and will not throw error
// Last => Gets last element, if no elements it will throw error
// LastOrDefault => Gets last element, if no elements will return default and will not throw error
// Single => Gets the only element from list, if more than one elements or no elements will throw error
// SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

//Student startingWithB = SEDC.Students.SingleOrDefault(x => x.FirstName.StartsWith("B")); => ERROR
//there are more than one item starting with B in the list

Student studentGreg = SEDC.Students.SingleOrDefault(x => x.FirstName == "Greg");


//get the subjects for all part time students
var subjectsOfPartTime = SEDC.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();

//SelectMany flattens the list of lists. The members of each list in the list of lists become members of the result list
List<Subject> subjectsOfPartTimeStudents = SEDC.Students.Where(x => x.IsPartTime)
                                            .SelectMany(x => x.Subjects).ToList();

//ANY
//check if there are part time students at SEDC
List<Student> partTimeStudents = SEDC.Students.Where(x => x.IsPartTime).ToList();
//first way
bool areTherePartTimeStudents = partTimeStudents.Count > 0;

//second way
int numberOfPartTimeStudents = SEDC.Students.Count(x => x.IsPartTime);
bool check = numberOfPartTimeStudents > 0;

//checks if there is at least one student that is part time
bool checkPartTime = SEDC.Students.Any(x => x.IsPartTime);


//ALL -checks if all members of some collection fullfil a condition
//check if all students have names shorter than 4 characters
bool checkShortNames = SEDC.Students.All(x => x.FirstName.Length < 4);

List<int> numbers = new List<int>() { 4, 6, 4, 6 };
List<int> distinctNumbers = numbers.Distinct().ToList();

//ORDER BY - doesn't change the original list
//default OrderBy -> orders in ascending order (starting from lower values)
List<Student> sortedByAge = SEDC.Students.OrderBy(x => x.Age).ToList();
//order students starting from highest to lowest age
List<Student> sortedByAgeDesc = SEDC.Students.OrderByDescending(x => x.Age).ToList();

Console.ReadLine();


