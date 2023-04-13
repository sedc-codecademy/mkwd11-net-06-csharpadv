//PASSING METHOD AS ARGUMENT TO SOME OTHER METHOD
//Greeting is void, has one string param and one method parameter, which need to follow the signature from PrintDelegate
void Greeting(string name, PrintDelegate printDelegate)
{
    printDelegate(name); //SayHello("Ana")
}

//this method follows the signature from PrintDelegate
void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");
}

//in this call of Greeting method, we pass SayHello method as second argument
//SayHello comes as value for printDelegate parameter of Greeting method
//it can be called through printDelegate parameter, and we can give it a string parameter (name)
Greeting("Ana", SayHello);
Greeting("Bob", x => Console.WriteLine($"Welcome {x}"));


//INSTANCES OF DELEGATES

//follows NumbersDelegate signature
int Sum(int num1, int num2)
{
    return num1 + num2;
}

NumbersDelegate numbersDelegate = new NumbersDelegate(Sum);
numbersDelegate(1, 3); // => Sum(1, 3);

//you can pass an anonymous method
PrintDelegate printDelegate = new PrintDelegate(SayHello);
printDelegate("SEDC");
PrintDelegate secondPrintDelegate = new PrintDelegate(x => Console.WriteLine($"Goodbye {x}"));
secondPrintDelegate("John");




//Declaring delegates
//delegate defines signature of a given method
//when we see PrintDelegate through the code, we need to expect a method with this signature -> void and one string param
delegate void PrintDelegate(string text);
//when we see NumbersDelegate through the code, we need to expect a method with this signature -> int and two int params
delegate int NumbersDelegate(int num1, int num2);
