namespace Class10_DisposeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Example\\file.txt";
            Directory.CreateDirectory("Example");
            File.Create(path).Close();


            //CustomWriter myWriter = new CustomWriter(path);
            //myWriter.WriteLine("This is my line: 1");
            //myWriter.Dispose();

            using (CustomWriter myWriter = new CustomWriter(path))
            {
                myWriter.WriteLine("This is my line: 1");
                myWriter.WriteLine("This is my line: 2");
            }

            string pathLog = "Example\\log.txt";
            File.Create(pathLog).Close();

            //while (true)
            //{
            using (MyLogger logger = new MyLogger(pathLog))
            {
                try
                {
                    List<string> names = new List<string> { "risto" };
                    Console.WriteLine(names[5]);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex);
                }
            }
            //}

        }
    }
}