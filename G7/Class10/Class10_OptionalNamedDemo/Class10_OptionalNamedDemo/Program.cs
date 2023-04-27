namespace Class10_OptionalNamedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Calculate(3, 4, "+");
            int result1 = Calculate(operatoration: "+", b: 3, a: 4);

            int r1 = CalculateOptional();
            int r2 = CalculateOptional(3, 3);
            int r4 = CalculateOptional(7);
            int r3 = CalculateOptional(5, 7, "*");

            int r5 = CalculateOptional(b: 10);
            int r6 = CalculateOptional(operatoration: "-");


            Person p = new Person("Risto");
            Person p1 = new Person("Tijana", "Manager");
        }

        static int Calculate(int a, int b, string operatoration)
        {
            switch (operatoration)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                default:
                    throw new Exception("Operation not supported");
            }
        }

        static int CalculateOptional(int a = 2, int b = 2, string operatoration = "+")
        {
            switch (operatoration)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                default:
                    throw new Exception("Operation not supported");
            }
        }
    }
}