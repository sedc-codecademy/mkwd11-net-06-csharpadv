
using System.Threading.Channels;

List<string> names = new List<string>()
{
    "Bob", "Jill", "Doe", "Wayne", "John", "Anne"
};

List<string> emptyList = new List<string>();

bool IsNameListEmpty()
{
    return names.Count == 0;
}
bool IsListEmpty(List<string> items)
{
    return items.Count == 0;
}

Console.WriteLine($"Is names list empty: {IsNameListEmpty()}");
Console.WriteLine($"Is any list empty: {IsListEmpty(names)}");



#region Anonymous methods using - Func

Func<bool> isNamesListEmpty = () => names.Count == 0;
Func<List<string>,  bool> isAnyListEmpty = x => x.Count == 0;

Console.WriteLine($"Is names list empty: {isNamesListEmpty()}");
Console.WriteLine($"Is any list empty: {isAnyListEmpty(names)}");
Console.WriteLine($"Is any list empty: {isAnyListEmpty(emptyList)}");

// int1 -> First param
// int2 -> Second param
// int3 -> Return type of the anonymous function
// The return type is always at the end.
// If there is only Func<int> that means that the function has NO input params and returns int

Func<int, int, int> sum = (x, y) => x + y;
Func<int, int, int> diff = (x, y) => x - y;
Func<int, int, int> multiply = (x, y) => x * y;
Func<double, double, double> div = (x, y) =>
{
    if (y == 0)
        throw new DivideByZeroException("Cannot divide by zero!");
    return x / y;
};

Console.WriteLine("-----------------------");
try
{
    Console.WriteLine(sum(193, 1087));
    Console.WriteLine(diff(2567, 1087));
    Console.WriteLine(multiply(193, 1087));
    Console.WriteLine(div(190, 80));
    Console.WriteLine(div(190, 0));
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ForegroundColor = ConsoleColor.White;
}


Func<int, int, int> checkLarger = (x, y) => x > y ? x : y;

Console.WriteLine($"What number is larger from 10 and 5: Larger is {checkLarger(10, 5)}");
Console.WriteLine($"What number is larger from 10 and 5: Larger is {checkLarger(5, 10)}");
#endregion


#region Anonymous methods using - Action

Action hello = () => Console.WriteLine("Hello there from Action!");
Action<string> sayHi = name => Console.WriteLine($"Hi there {name}");

hello();
sayHi("Martin");
sayHi("Monika");
sayHi("Marija");
sayHi("Koki");
sayHi("Damjan");


Action<string> printInRed = x =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(x);
    Console.ResetColor();
};


Action<string, ConsoleColor> printInColor = (message, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};


printInRed("Red hat hackers!");

//printInColor("Get", ConsoleColor.Red);
//Thread.Sleep(3000);
//printInColor("Set", ConsoleColor.Yellow);
//Thread.Sleep(3000);
//printInColor("Gooooo!!!!", ConsoleColor.Green);
//Thread.Sleep(3000);




#endregion

#region High order Function Use
Console.WriteLine("-----------------------------------------------");
string foundBob = names.Find(x => x.ToLower() == "bob");
Console.WriteLine(foundBob);


Func<string, bool> userIsJill = x => x == "Jill";

string jill = names.Where(userIsJill).FirstOrDefault();
string jill1 = names.FirstOrDefault(userIsJill);


Func<string, bool> startsWithCharJ = x => x.StartsWith("J");

List<string> namesThatStartsWithJ = names.Where(startsWithCharJ).ToList();

namesThatStartsWithJ.ForEach(Console.WriteLine);

Console.WriteLine("=================================");
names.ForEach(Console.WriteLine);


Action<string> printElements = x => Console.WriteLine(x);

void Print(string x)
{
    Console.WriteLine(x);
}

names.ForEach(printElements);
names.ForEach(Print);




#endregion