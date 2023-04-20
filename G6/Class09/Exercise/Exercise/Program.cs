string Calculation(int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

string folderPath = @"..\..\..\Exercise";
string filePath = @"..\..\..\Exercise\calculations.txt";

try
{
    Console.WriteLine("Enter first number");
    string firstInput = Console.ReadLine();

    Console.WriteLine("Enter second number");
    string secondInput = Console.ReadLine();

    string result = Calculation(int.Parse(firstInput), int.Parse(secondInput));

    if (!Directory.Exists(folderPath))
    {
        Directory.CreateDirectory(folderPath);
    }

    using(StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine($"{DateTime.Now: dd.MM.yyyy HH:mm:ss} : {result}");
        sw.WriteLine("========================");
    }
}
catch(Exception e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
