namespace Class09_LoggerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> names = new List<string> { "risto" };

                Console.WriteLine(names[5]);
            } catch (Exception ex)
            {
                Console.WriteLine("An error happend, please try again later");

                string folderPath = @"..\..\..\Logs";
                string filePath = folderPath + @$"\logs_{DateTime.UtcNow.ToString("dd-MM-yyyy")}.txt";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                //Opens a streamWriter that is a disposable object that will be closed (damaged) once the using block finishes
                //Creating a StreamWriter only with filePath, creates a streamwriter with the option to override the content of that file.
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write($"{DateTime.UtcNow} Error: {ex}");
                }
            }
        }
    }
}