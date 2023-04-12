List<string> names = new List<string>() { "John", "Kate", "Ana", "Bob" };

//Func => used to store method that returns a value, and can have no parameters or one or more parameters
//we are reading left to right, Func<int, string, bool> means that we have a function that takes int and string as params
//and returns bool as result

//we are storing anonymous method, that takes one parameter of type List<string> and returns result of type boolean
Func<List<string>, bool> checkIfListIsEmpty = (x) => x.Count == 0;

//Func<List<T>, bool> checkempty = (x) => x.Count == 0; => we can't use them with generics

bool namesIsEmpty = checkIfListIsEmpty(names);

//method which doesn't take parameters and returns int
Func<int> sumOfTwoAndFive = () => 2 + 5;
Console.WriteLine(sumOfTwoAndFive());

Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine(sum(3, 5));

//find the first name with length 3 - using Func with LINQ
Func<string, bool> namesIsOfLengthThree = x => x.Length == 3;
names.FirstOrDefault(namesIsOfLengthThree);

//if we have many lines of code in the body of the anonymous method, we use {}
Func<int, int, bool> isFirstNumLarger = (x, y) => 
{
    if (x > y)
        return true;
    return false;
};
Console.WriteLine($"Is 5 larger than 3 {isFirstNumLarger(5, 3)}");

List<int> ints = new List<int>() { 2, 5, 7, 8, 9 };
List<int> secondListOfInts = new List<int>() { 2, 5, 45, 8, 34 };
var even = ints.Where(x => x % 2 == 0);
//written with Func
Func<int, bool> checkEven = x => x % 2 == 0;

List<int> evenNumbers = ints.Where(checkEven).ToList();
Console.WriteLine(evenNumbers.Count);
//we can reuse the func
List<int> evenIntsFromSecondList = secondListOfInts.Where(checkEven).ToList();
Console.WriteLine(evenIntsFromSecondList.Count);

Func<string, bool> startsWithJ = x => x.StartsWith("J");
List<string> namesStartingWithJ = names.Where(startsWithJ).ToList();


//Action - Action is always void
Action sayHello = () => Console.WriteLine("Hello World");

//printRed is a function that is void, and gets only one parameter of type string
Action<string> printRed = x =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(x);
    Console.ResetColor();
};
printRed("Hello");

Action<string, ConsoleColor> printColor = (message, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};
printColor("Hello World", ConsoleColor.Green);
