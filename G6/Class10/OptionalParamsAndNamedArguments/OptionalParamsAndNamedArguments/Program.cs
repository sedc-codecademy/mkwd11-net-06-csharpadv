using System.Runtime.CompilerServices;

//this method has no optional params, we must provide arguments (values) for all three params
void CalculationNoOptionalParameters(int num1, int num2, string operation)
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
            Console.WriteLine("Invalid operation");
                break;
    }
}

CalculationNoOptionalParameters(3, 4, "+");
//CalculationNoOptionalParameters(5, 6); //we must provide values for params!!!!

//we must provide values for num1 and num2, but if we don't provide value for operation, it will get value +
//ALWAYS PUT REQUIRED PARAMS FIRST, THEN THE OPTIONAL ONES  
void CalculationSomeOptionalParameters(int num1, int num2, string operation = "+")
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
            Console.WriteLine("Invalid operation");
            break;
    }
}

CalculationSomeOptionalParameters(5, 7, "-"); //operation will get the value "-"
CalculationSomeOptionalParameters(9, 8); //operation will get value "+"

void CalculationAllOptionalParameters(int num1 = 0, int num2 = 0, string operation = "+")
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
            Console.WriteLine("Invalid operation");
            break;
    }
}

CalculationAllOptionalParameters(); //0,0, +
CalculationAllOptionalParameters(1); // num1 = 1, num2 = 0, operation = +
CalculationAllOptionalParameters(1, 3); // num1 = 1, num2 = 3, operation = +
CalculationAllOptionalParameters(1, 3, "-"); // num1 = 1, num2 = 3, operation = -

//NAMED ARGUMENTS
CalculationAllOptionalParameters(num1: 1, num2: 3, operation: "-");
CalculationAllOptionalParameters(num2: 1, num1: 3, operation: "-"); //when using named argument, you can change order
//of passing values

