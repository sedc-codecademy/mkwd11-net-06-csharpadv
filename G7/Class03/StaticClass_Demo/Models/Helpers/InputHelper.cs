namespace Models.Helpers
{
    public static class InputHelper
    {
        public static int InputInteger()
        {
            string input = Console.ReadLine();

            if(!int.TryParse(input, out int number))
            {
                throw new Exception("Wrong input");
            }

            return number;
        }
    }
}
