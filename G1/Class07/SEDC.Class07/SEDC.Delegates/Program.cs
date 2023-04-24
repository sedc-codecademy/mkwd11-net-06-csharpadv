

SayDelegate sayHello = new SayDelegate(WriteToConsole);
SayDelegate sayHelloWithRedColor = new SayDelegate(WriteWithRedColor);


sayHello("Hello there Martin");
sayHelloWithRedColor("Hello there we are learning delegates");

Console.WriteLine("-------------------------------------------");
SaySomething(sayHello, 1);
SaySomething(sayHelloWithRedColor, 2);


void WriteToConsole(string text)
{
    Console.WriteLine(text);
}
void WriteWithRedColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}
void SaySomething(SayDelegate sayMechanism, int counter)
{
    sayMechanism($"Text from method {counter}");
}

Console.WriteLine("-------------------------------------------");


CalculateDelegate addTwoNumbers = AddNumbers;
CalculateDelegate subTwoNumbers = SubtractNumbers;


// This will not work because there is no overload for Square method that 
// return int and accept two integers as inputs 
//CalculateDelegate squareNumber = Square;

Console.WriteLine($"4 + 5 = {addTwoNumbers(4, 5)}");
Console.WriteLine($"10 - 3 = {subTwoNumbers(10, 3)}");
PerformCalculations(addTwoNumbers, subTwoNumbers, sayHelloWithRedColor, 20, 30);
PerformCalculations(addTwoNumbers, subTwoNumbers, WriteWithRedColor, 50, 100);


int AddNumbers(int firstNum, int secondNum)
{
    return firstNum + secondNum;
}
int SubtractNumbers(int firstNum, int secondNum)
{
    return firstNum - secondNum;
}
void PerformCalculations(CalculateDelegate addTwoNumbers, CalculateDelegate subTwoNumbers, SayDelegate sayWithRed, int firstNum, int secondNum)
{
    sayWithRed($"Addition of: {firstNum} and {secondNum} is {addTwoNumbers(firstNum, secondNum)}");
    sayWithRed($"Subtraction of: {firstNum} and {secondNum} is {subTwoNumbers(firstNum, secondNum)}");
}

//int Square(int num)
//{
//    return num * num;
//}


delegate void SayDelegate(string text);
delegate int CalculateDelegate(int firstNumber, int secondNumber);