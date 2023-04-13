using AdvancedLINQ;
using AdvancedLINQ.Domain;
using AdvancedLINQ.Domain.Entities;

List<Student> studentsOlderThan25 = SEDC.Students.Where(x => x.Age >= 25).ToList();

studentsOlderThan25.PrintEntities();

List<Student> studentsNamedBob = SEDC.Students.Where(x => x.FirstName == "Bob").ToList();

studentsNamedBob.PrintEntities();

var studentsNamedBobSQL = from student in SEDC.Students //from all students in list SEDC.Stundets
                          where student.FirstName == "Bob" //filter the objects by this expression
                          select student;

studentsNamedBobSQL.ToList().PrintEntities();

List<string> fullNames = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();

fullNames.PrintSimple();

List<string> fullNamesSQL = (from student in SEDC.Students
                             select $"{student.FirstName} {student.LastName}").ToList();

fullNamesSQL.PrintSimple();

//FIRST
Student studentGreg = SEDC.Students.First(x => x.FirstName == "Greg"); //if not found, an exception will be thrown
Student studengGreg2 = SEDC.Students.FirstOrDefault(x => x.FirstName == "Greg"); //if not found, the value is null

//SINGLE
Student studentGreg3 = SEDC.Students.Single(x => x.FirstName == "Greg");//if found more than 1, an exception will be thrown
Student studentGreg4 = SEDC.Students.SingleOrDefault(x => x.FirstName == "Greg");//if found more than 1, the value is null

//LAST => The same as First but gets the last element
Student studentGreg5 = SEDC.Students.Last(x => x.FirstName == "Greg"); //if not found, an exception will be thrown
Student studengGreg6 = SEDC.Students.LastOrDefault(x => x.FirstName == "Greg"); //if not found, the value is null

//ANY
List<Student> studentsThatWorkPartTimeComplex = SEDC.Students.Where(x => x.IsPartTime).ToList();
bool areTherePartTimeStudents = studentsThatWorkPartTimeComplex.Count > 0;

bool studentsThatWorkPartTimeSimple = SEDC.Students.Any(x => x.IsPartTime); //the same as above but simpler

//ALL => checks if all memebers fulfill the condition
bool areNamesLongerThat4Char = SEDC.Students.All(x => x.FirstName.Length > 4);

//DISTINCT
List<int> numeros = new List<int>() { 2, 4, 2, 4, 2, 4 };
List<int> numerosNoDuplicatos = numeros.Distinct().ToList();

numerosNoDuplicatos.PrintSimple();

//ORDER BY
List<Student> sortedByAge = SEDC.Students.OrderBy(x => x.Age).ToList(); //starting from the lowest value *ASCENDING*
List<Subject> subjects = SEDC.Subjects.OrderBy(x => x.Title[0]).ToList();

List<Subject> subjectsStudentsByDSC = SEDC.Subjects.OrderByDescending(x => x.StudentsAttending).ToList();