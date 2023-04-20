using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{
    public class LoggerService
    {
        private string _folderPath;
        private string _filePath;

        public LoggerService()
        {
            _folderPath = @"..\..\..\logs";
            _filePath = @"..\..\..\logs\log.txt";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        public void Log(string message, bool isError)
        {
            using(StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine($"Time: {DateTime.Now}");
                if (isError)
                {
                    sw.WriteLine($"ERROR message: {message}");
                }
                else
                {
                    sw.WriteLine($"INFO message: {message}");
                }
                sw.WriteLine("=======================");
            }
        }
    }
}
