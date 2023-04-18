using DelegatesPartTwo;

Calculator calculator = new Calculator();

int sumResult = calculator.Calculate(calculator.Sum, 10, 20);
Console.WriteLine(sumResult);

int multiplyResult = calculator.Calculate(calculator.Multiply, 5, 20);
Console.WriteLine(multiplyResult);

int result = calculator.Calculate((int num1, int num2) => num1 + num2, 50, 10);
Console.WriteLine(result);

Console.ReadLine();