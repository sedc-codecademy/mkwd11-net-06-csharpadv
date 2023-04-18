namespace Class07_DelegatesDemo
{
    internal class Program
    {
        //declaration of a delegate
        delegate void PrintDelegate(string text);
        delegate void MathFunctionDelegate(int a, int b);

        static void Main(string[] args)
        {
            //Delegate that points (references) one function. Calling that delegate will invoke the method that is pointed out.
            PrintDelegate delegate1 = new PrintDelegate(WelcomeMessage);

            //WelcomeMessage("Risto");
            delegate1("Risto");

            //Instance of a delegate
            PrintDelegate delegate2 = new PrintDelegate(SayHello);
            delegate2("Risto");

            //aggregatedDelegate that points out to two methods (WelcomeMessage and SayHello) when we call the aggregatedDelegate it will invoke both of the methods that it points out
            PrintDelegate aggregatedDelegate = new PrintDelegate(WelcomeMessage);
            PrintDelegate d1 = new PrintDelegate(SayHello);
            aggregatedDelegate += d1;

            aggregatedDelegate -= d1;


            MathFunctionDelegate d = new MathFunctionDelegate(Sum);
            d += new MathFunctionDelegate(Sub);
            d += new MathFunctionDelegate(Mult);
            d += new MathFunctionDelegate(Devide);

            //MathFunctionDelegate d = new MathFunctionDelegate(Sum) + new MathFunctionDelegate(Sub) + new MathFunctionDelegate(Mult) + new MathFunctionDelegate(Devide);

            d(3, 4);

            MathOperation(5, 7, new MathFunctionDelegate(Sum));
        }

        static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome to SEDC: {name}");
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine($"Sub: {a - b}");
        }

        static void Mult(int a, int b)
        {
            Console.WriteLine($"Mult: {a * b}");
        }

        static void Devide(int a, int b)
        {
            Console.WriteLine($"Devide: {a / (decimal)b}");
        }

        static void MathOperation(int a, int b, MathFunctionDelegate d)
        {
            Console.WriteLine($"Based on your input: {a}, {b}, the result is: ");
            d(a, b);
        }
    }
}