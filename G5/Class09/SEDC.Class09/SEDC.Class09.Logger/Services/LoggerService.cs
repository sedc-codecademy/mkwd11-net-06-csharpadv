namespace SEDC.Class09.Logger.Services
{
    public class LoggerService
    {
        private string _directoryPath = @"..\..\..\Logs";
        private string _logPath = @"..\..\..\Logs\log.txt";
        private string _errorCountPath = @"..\..\..\Logs\errorCount.txt";

        public LoggerService()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if(!File.Exists(_logPath))
            {
                File.Create(_logPath);
            }

            if(!File.Exists(_errorCountPath))
            {
                File.Create(_errorCountPath);
            }
        }

        public void Log(string error, string message, string username = "Unknown")
        {
            using (StreamWriter sw = new StreamWriter(_logPath, true))
            {
                sw.WriteLine($"Error: {error}");
                sw.WriteLine($"Time: {DateTime.Now.ToLocalTime()}");
                sw.WriteLine($"Message: {message}");
                sw.WriteLine($"User: {username}");
                sw.WriteLine("===================================================");

                // Error: Exception
                // Time: 10/10/2000 6:10:15 PM
                // Message: Invalid Credentials
                // User: Angel
            }
        }

        public void LogError()
        {
            int count = 0;

            using(StreamReader sr = new StreamReader(_errorCountPath))
            {
                bool isParsed = int.TryParse(sr.ReadLine(), out count);
            }

            using(StreamWriter sw = new StreamWriter(_errorCountPath))
            {
                sw.WriteLine(count + 1);
            }
        }
    }
}
