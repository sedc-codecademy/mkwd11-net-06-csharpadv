void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");
}

void SayBye(string name)
{
    Console.WriteLine($"Bye {name}");
}

Console.WriteLine("==== Instantinting a delegate with method");
SayDelegate bob = new SayDelegate(SayHello);// The SayDelegate points to SayHello
SayDelegate sayBye = new SayDelegate(SayBye);// The SayDelegate points to SayBye
SayDelegate anonymousMethod = new SayDelegate(x=>Console.WriteLine($"Zdravo {x}"));// The SayDelegate points to an anonymous method

// Using the delegate ( Points to methods )
bob("Bob");
sayBye("Angel");
anonymousMethod("Mitko");

Console.WriteLine("====== Passing a Method =======");

void DelegateSay(string message, SayDelegate sayDelegate)
{
    Console.WriteLine("Delegate say:");
    sayDelegate(message);
}


DelegateSay("Bob", SayHello);
DelegateSay("Dimitar", SayBye);
DelegateSay("Anne", x => Console.WriteLine($"Stuff with {x}"));

Console.WriteLine("====== Making a high order method ======");

void Number(int num1, int num2, NumbersDelegate numbersDelegate)
{
    Console.WriteLine( $"Delegate calculate:{numbersDelegate(num1,num2)}");
}

Number(1, 2, (x, y) => x + y);
Number(45, 20, (x, y) => x - y);
Number(23, 10, (x, y) =>
{
    if (x > y)
    {
        return x;
    }
    return y;
});

// Declaring delegates
// This is the signature of any method that we want this delegate to point to
delegate void SayDelegate(string something);
delegate int NumbersDelegate(int numOne, int numTwo);



