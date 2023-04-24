List<string> names = new List<string>()
{
    "Bob", "Jill", "Wayne", "Greg", "John", "Anne"
};

//ACTION
//action is always void

Action hello = () => Console.WriteLine("Hello there!");

Action<string> printRed = message =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
};

Action<string, ConsoleColor> printColor = (message, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};

hello();
printRed("some error message");
printColor("some error message", ConsoleColor.Magenta);


//static void DoSomething(string message, Action<string> doSomethingAction)
//{
//    Console.WriteLine("inside Do Something");
//    doSomethingAction(message);
//    Console.WriteLine("inside Do Something 2");
//}

//DoSomething("some message from outside", message => 
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine(message);
//    Console.ResetColor();
//});

//DoSomething("some message from outside 2", message =>
//{
//    Console.ForegroundColor = ConsoleColor.Magenta;
//    Console.WriteLine(message);
//    Console.ResetColor();
//});

//FUNCTION
//function always has a return value

Func<bool> isNameEmpty = () => names.Count == 0;

Func<List<string>, bool> isListEmpty = arr => arr.Count == 0;

Func<int, int, int> sum = (number1, number2) => number1 + number2;

Func<int, int, bool> checkIfLarger = (number1, number2) =>
{
    if (number1 > number2) 
    {
        return true;
    }

    return false;
};

Console.WriteLine(isNameEmpty());
Console.WriteLine(isListEmpty(names));
Console.WriteLine(sum(5, 10));
Console.WriteLine(checkIfLarger(4, 8));