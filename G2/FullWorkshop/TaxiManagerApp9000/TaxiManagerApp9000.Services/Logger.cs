using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public class Logger : ILogger
    {
        private string _directoryPath = "../../../logs";
        private string _logFilePath = $"../../../logs/log-{DateTime.Today.Date.ToString("dd-MM-yyyy")}.log";

        public Logger()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if (!File.Exists(_logFilePath))
            {
                File.Create(_logFilePath).Close();
            }
        }
        public void Log(string logType, string error, string message, string username)
        {
            string logMesage = $"Date: {DateTime.UtcNow} LogType: {logType} user: {username} - {error} : {message}";

            using (StreamWriter sw = new StreamWriter(_logFilePath, true))
            {
                sw.WriteLine(logMesage);
            }
        }
    }
}
