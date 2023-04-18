int Calculate(int x, int y)
{
    return x + y;
};

Func<int, int, int> calc = Calculate;

calc(5, 4);

CalculateDelegate calc2 = Calculate;

calc2(5, 4);

Action<int, int> calc3 = (x, y) => Console.WriteLine(x + y);

calc3(5, 4);

public delegate int CalculateDelegate(int x, int y);