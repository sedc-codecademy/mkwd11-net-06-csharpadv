


void CheckOperation(int num1, int num2, string operation) 
{
	switch (operation)
	{
		case "+":
            Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
			break;
        case "-":
            Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2}");
            break;
        default:
            Console.WriteLine($"This app does not work with {operation}");
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

void AllOptional(int num1 = 5, int num2 = 10, string operation = "+") 
{
    CheckOperation(num1, num2, operation);
}


NoOptional(2, 3, "+");
//NoOptional(2, 3); not working

SomeOptional(10, 5, "-");
SomeOptional(10, 5);
//SomeOptional(); not working

AllOptional();
AllOptional(5);
AllOptional(5, 10);
AllOptional(5, 10, "-");
//AllOptional("-"); not working

AllOptional(num2: 10);
AllOptional(operation: "%");