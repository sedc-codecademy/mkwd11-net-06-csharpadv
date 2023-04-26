void CheckOperation(int num1, int num2, string operation)
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            break;
        default:
            Console.WriteLine("What are you doing ?!");
            break;
    }
}

void NoOptional(int num1, int num2, string operation)
{
    CheckOperation(num1, num2, operation);
}

void SomeOptional(int num1, int num2, string operation = "+")
{
    CheckOperation(num1, num2, operation);
}

void AllOption(int num1 = 5, int num2 = 10, string operation = "+")
{
    CheckOperation(num1, num2, operation);
}

NoOptional(5, 6, "+");
SomeOptional(5, 7, "-");
SomeOptional(num1: 3, operation: "-", num2: 6);
SomeOptional(2, 5);
AllOption();
AllOption(7);
AllOption(operation: "-", num1: 2);
