List<string> names = new List<string>();

names.Add("Bojan");
names.Add("Ilija");
names.Add("Valjmir");
names.Add("Maja");
names.Add("Mario");
names.Add("Dejan");
names.Add("Sime");

//Func is a delegate that points to a method, in other words it holds the method inside it. We begin from left to right and the last paramter on the right is the return type.
Func<List<string>, bool> checkIfListIsEmpty = (x) => x.Count == 0;

Console.WriteLine(checkIfListIsEmpty(names));

//Func method that onyl returns something but doesn't get any paramter.
Func<int> sumOfTwoNums = () => 10 + 12;
Console.WriteLine(sumOfTwoNums());

//FUnc that returns int and gets 2 parameters
Func<int, int, int> sumOfTwoNumsParameters = (x, y) => x + y;
Console.WriteLine(sumOfTwoNumsParameters(23, 54));

//Func can have many lines of code, but that's not the Func, that's the anonymous method that has many lines of code !!!
Func<int, int, bool> isFirstNumLarger = (x, y) =>
{
    if (x > y)
    {
        return true;
    };
    return false;
};

Func<int, int, bool> isFirstNumLargerOneLine = (x, y) => x > y;

Console.WriteLine(isFirstNumLarger(5, 6));
Console.WriteLine(isFirstNumLarger(6, 2));

Console.WriteLine(isFirstNumLargerOneLine(5, 2));

List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
List<int> secondListOfInts = new List<int>() { 2, 5, 45, 8, 34 };

List<int> even = ints.Where(x => x % 2 == 0).ToList();

//The same query but with Func
Func<int, bool> checkEven = x => x % 2 == 0;
List<int> evenNumbers = ints.Where(checkEven).ToList();
List<int> evenNumbers2 = secondListOfInts.Where(checkEven).ToList();

//Action is like Func, but Action only has parameters and doesn't return anything!!!

Action sayHello = () => Console.WriteLine("Hello from Marko");

sayHello();

Action<string> printText = x =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(x);
    Console.ResetColor();
};

printText("Goodbye from Damjan");

Action<string, ConsoleColor, ConsoleColor> printTextParameters = (x, y, z) =>
{
    Console.ForegroundColor = z;
    Console.BackgroundColor = y;
    Console.WriteLine(x);
    Console.ResetColor();
};

printTextParameters("Slave tested every scenario possible.", ConsoleColor.Red, ConsoleColor.Green);