namespace Class09_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string folderPath = "Exercise";
            const string filePath = $"{folderPath}\\calculations.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Do math operation");
                Console.WriteLine("2. See the history");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            Console.Write("Please enter the first number: ");
                            string firstNumberString = Console.ReadLine();

                            Console.Write("Please enter the second number: ");
                            string secondNumberString = Console.ReadLine();

                            if(!int.TryParse(firstNumberString, out int firstNumber) ||
                               !int.TryParse(secondNumberString, out int secondNumber))
                            {
                                Console.WriteLine("Wrong input");
                                break;
                            }

                            string result = Sum(firstNumber, secondNumber);
                            Console.WriteLine(result);

                            using(StreamWriter sw = new StreamWriter(filePath, true))
                            {
                                sw.WriteLine($"[{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}] {result}");
                            }

                            break;
                        }
                    case "2":
                        {
                            using(StreamReader sr = new StreamReader(filePath))
                            {
                                Console.WriteLine("------History------");
                                string fullContent = sr.ReadToEnd();
                                Console.WriteLine(fullContent);

                                //while(true)
                                //{
                                //    string line = sr.ReadLine();

                                //    if(line == null)
                                //    {
                                //        break;
                                //    }

                                //    Console.WriteLine(line);
                                //}
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        static string Sum(int a, int b)
        {
            return $"{a} + {b} = {a + b}";
        }
    }
}