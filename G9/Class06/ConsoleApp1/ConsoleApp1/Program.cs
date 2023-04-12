//// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//EXAMPLE OF USING REF KEYWORD

////int a = 7;
////int b = 10 ;

////void Swap(ref int x, ref int y)
////{
////    var temp = x; 
////    x = y; 
////    y = temp;
////}

////Swap(ref a, ref b);
////Console.WriteLine();

//var str = "This is anonymous method";

//EXAMPLE OF LAMBDA EXPRESSION

//str.Where(x => x.ToString() == "test");

//FUNC Delegate without parameters 

//Func<int> func = () => 2;

////Console.WriteLine(func());
///

//FUNC Delegate with 1 int parameters and lambda exporession

//Func<int, int> func2 = (x) => x;

//FUNC Delegate with 2 int parameters and lambda statement

//Func<int, int, int> func3 = (x, y) =>
//{
//    if (x < 0)
//    {
//        return 0;
//    }

//    return x + y;
//};

//// Func so ke primat string i ke vrakat int
//// so ke gi brojt zborojte vo stringot

////Func<string, int> func4 = (x) =>
////{
////    return x.Split(" ").Length;
////};

////List<string> names = new List<string>()
////{
////    "Bob", "Jill", "Wayne", "Greg", "John", "Anne"
////};



////Func<string, bool> strs = (x) =>
////{
////        return x == "Bob";

////};
////var name = names.Where(TestText);


////bool TestText(string ts)
////{
////    return ts == "Bob";
////}

//Action strAct = () => 
//Console.WriteLine("Test");

//strAct();

////Same example shown in Linq and Sql queries


////Linq Method syntax 
//var students = DbLoad.Students.Where(x => x.Id > 0);

////Linq Query syntax
//var students1 = from x in DbLoad.Students
//                where x.Id > 0
//                select x;


////Sql query
//// select * from DbLoad.Students
//// where Id > 0

//Same example shown with Linq method and query sintax


////Linq Method syntax 
//var selectedOperator = DbLoad.Students.Select(x =>  new {x.Id, x.Age}).ToList();

////Linq Query syntax
//var selectedOperator = from x in DbLoad.Students
//                       select new {x.Id, x.Age};

//Console.WriteLine();

//// Chained linq query that finds all students who are on part time and who has Academy.Design subject

//var selectedArr = DbLoad.Students.Where(x=>x.IsPartTime)
//                                 .Where(z=>z.Subjects.Where(f =>f.Type == Academy.Design)
//                                 .ToList()
//                                 .Any());


//Select query that returns only the first names of the Students whos name starts with B

//var test = DbLoad.Students.Where(x => x.FirstName.StartsWith("B"))
//                          .Select(x => x.FirstName).ToList();

//var chainedArr = DbLoad.Students.Where(x => x.IsPartTime)
//                                 .Where(z=>z.Subjects.Where(f=>f.Type == Academy.Design)
//                                 .ToList()
//                                 .Any()) ;

////Example of First and FirstOrDefault as linq operators

//var firstStudent = DbLoad.Students.First();
//var firstStudentDefault = DbLoad.Students.FirstOrDefault(x=>x.IsPartTime);

////Example of Last and LastOrDefault as linq operators

//var lastStudent = DbLoad.Students.Last();
//var lastStudentDefault = DbLoad.Students.LastOrDefault(x=>x.IsPartTime);

////Example of FindLast as linq operator

//var findLast = DbLoad.Students.FindLast(x=>x.IsPartTime);

////Example of Single and SingleOrDefault as linq operators

//var singleStudent = DbLoad.Students.Single(x=>x.Id == 12);

//var singleOrDefault = DbLoad.Students.SingleOrDefault(x=>x.Id == 13);

////Example of Select and SelectMany as linq operators

var selectMany = DbLoad.Students.Where(x=>x.IsPartTime)
                                .Select(z=>z.Id).ToList();

var selectMany2 = DbLoad.Students.Where(x => x.IsPartTime)
                                  .SelectMany(x => x.Subjects).ToList();

////Example of Distinct as linq operator

var distinct = selectMany2.Distinct();


////Example of Any as linq operator

var anyArr = DbLoad.Students.Any(x => x.Id < 13);


////Example of All as linq operator

var arrArr = DbLoad.Students.All(x => x.Id < 13);


////Example of OrderBy ascending order as linq operator
//// This example will order all of the students by their IsPartTime property and then by their first name


var ordByArr = DbLoad.Students.OrderBy(x => x.IsPartTime).ThenBy(z=>z.FirstName);


////Example of OrderByDescending as linq operator

var ordByDesc = DbLoad.Students.OrderByDescending(x => x.FirstName);

Console.WriteLine();


