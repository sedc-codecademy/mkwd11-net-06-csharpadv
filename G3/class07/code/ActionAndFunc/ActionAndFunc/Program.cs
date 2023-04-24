List<string> names = new List<string>()
{
    "Bob", "Jill", "Wayne", "Greg", "John", "Anne"
};

//ACTION
//action is always void

Action hello = () => Console.WriteLine("Hello there dragan!");

Action<string> printRed = color =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(color);
    Console.ResetColor();
};

Action<string, int, int, bool> 
static void DoSomething(Action<string> doSomethingAction) 
{
    Console.WriteLine("inside Do Something");
    doSomethingAction("inside doSomethingAction");
}

DoSomething(printRed);
