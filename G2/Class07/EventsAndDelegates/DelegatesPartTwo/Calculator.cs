namespace DelegatesPartTwo
{
    public class Calculator
    {
        public delegate int Operation(int num1, int num2);

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Calculate(Operation operation, int num1, int num2)
        {
            return operation(num1, num2);
        }

    }
}
