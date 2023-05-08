namespace SEDC.Class14.GoodPractices.Practices
{
    public class IfElse
    {
        public void BadCheckIfEven(int num1, int num2)
        {
            // Check if two numbers are the same but only from 2 to 100 even numbers
            if (num1 <= 100 && num2 <= 100)
            {
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine("They are the same");
                    }
                }
            }
        }

        public void GoodCheckIfEven(int num1, int num2)
        {
            // Continue here ...
        }
    }
}
