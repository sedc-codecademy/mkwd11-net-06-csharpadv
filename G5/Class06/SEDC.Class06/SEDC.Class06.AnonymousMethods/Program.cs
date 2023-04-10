List<string> names = new List<string>()
{
    "Bob",
    "Jill",
    "Wayne",
    "Greg",
    "John",
    "Anne"
};

List<string> randomList = new List<string>();

#region Func
Console.WriteLine("=== Func ===");

// Func is anonymous method with a return type
// It can have 16 input parameters and 1 return type

int GetRandomNumber()
{
    return new Random().Next(1, 11);
}

int ReturnRandomNumber()
{
    return 150;
}

// Parametarless Anonymous Method
// int -> Return Type
Func<int> getRandomNumberAnonymous = () => new Random().Next(1, 11);

Func<int> getRandomNumberMethod = ReturnRandomNumber;
getRandomNumberMethod += () => 100;

Console.WriteLine($"Random Number: {GetRandomNumber()}");
Console.WriteLine($"Random Number Anonymous: {getRandomNumberAnonymous()}");
Console.WriteLine($"Random Number Method: {getRandomNumberMethod()}");


Console.WriteLine();
Console.WriteLine();

// Example of a func with 1 param
// List<string> -> param no.1
// bool -> return type (last type inside the generic)
Func<List<string>, bool> isListEmpty = (list) => list.Count == 0;

Console.WriteLine($"Is names list empty: {isListEmpty(names)}");
Console.WriteLine($"Is randomList list empty: {isListEmpty(randomList)}");



// Example of a func with 2 params
// int -> param no.1
// int -> param no.2
// int -> return type (last type inside the generic)
Func<int, int, int> sum = (num1, num2) => num1 + num2;
Console.WriteLine($"5 + 10 = {sum(5, 10)}");


// Multi-line anonymous method ( we need to open brackets )
// int -> param no.1
// int -> param no.2
// bool -> return type (last type inside the generic)
Func<int, int, bool> checkLarger = (num1, num2) =>
{
    if (num1 > num2)
        return true;

    return false;
};

Console.WriteLine($"5 > 10 = {checkLarger(5, 10)}");
Console.WriteLine($"15 > 10 = {checkLarger(15, 10)}");

#endregion

#region Action
// Action is always void (no return type)

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== Action ===");

void SayHelloMethod()
{
    Console.WriteLine("Hello!");
}


// Example of parameterless action
Action sayHello = () => Console.WriteLine("Hello there!");
sayHello();

Action sayHelloMethodExample = SayHelloMethod;
sayHelloMethodExample += () => Console.WriteLine("G5!");
sayHelloMethodExample();

// Example of action with 1 param
// string -> param no.1
Action<string> writeLineInRed = (message) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
};
writeLineInRed("Error occured!");



// Example of action with 2 params
// string -> param no.1
// ConsoleColor -> param no.2
Action<string, ConsoleColor> writeLineInColor = (message, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};
writeLineInColor("Error successfully resolved!", ConsoleColor.DarkGreen);

#endregion

#region Using Func and Action in LINQ
// LINQ takes Func/Action as parameter

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== Using Func and Action in LINQ ===");


string foundBob = names.Find(name => name == "Bob");
Console.WriteLine($"Found Bob - {foundBob}");



string jillFound = names.FirstOrDefault(name => name == "Jill");


/*
    "Bob", -> isJill("Bob") -> false -> next interation
    "Jill", -> isJill("Jill") -> true -> return
    "Wayne",
    "Greg",
    "John",
    "Anne"
 */

// We can create the Func first and then pass it in the LINQ method instead of a directly passing it
Func<string, bool> isJill = (name) => name == "Jill";
string foundJill = names.FirstOrDefault(isJill);


// We can also call the Func by itself
Console.WriteLine($"Is Jill {isJill("Jill")}");


Console.WriteLine($"Found Jill (Old) - {jillFound}");
Console.WriteLine($"Found Jill (New) - {foundJill}");


// Anonymous methods can be stored in a func or action
// They can later be used in LINQ
Func<string, bool> startsWithJ = name => name.StartsWith("J");
List<string> namesStartingWithJ = names.Where(startsWithJ).ToList();


Console.WriteLine();
Console.WriteLine("Names starting with J:");
Action<string> printName = (name) => Console.WriteLine(name);
namesStartingWithJ.ForEach(printName);

#endregion