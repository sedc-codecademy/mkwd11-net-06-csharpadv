while (true)
{
    try
    {
        Console.WriteLine("Enter first number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter operation for calculating: ( +, -, *, / )");
        char operation = char.Parse(Console.ReadLine());

        int result = operation switch
        {
            '+' or 'p' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num1 / num2,
            _ => throw new Exception("Invalid operation")
        };
        Console.WriteLine($"The result is {result}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("Do you want to try again? Y");
    string choise = Console.ReadLine();
    if (choise.ToLower() == "y") continue;
    break;
}