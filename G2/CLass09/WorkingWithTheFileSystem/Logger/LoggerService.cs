namespace Logger
{
    public class LoggerService
    {
        private string _folderPath;

        private string _filePath;

        public LoggerService()
        {
            _folderPath = "../../../logs";
            _filePath = _folderPath + "/logs.txt";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }

        public void Log(string message, bool isError = false)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine($"Time: {DateTime.Now}");
                if (isError)
                {
                    sw.WriteLine($"[###ERROR MESSAGE]: {message}");
                }
                else
                {
                    sw.WriteLine($"[###INFO MESSAGE]: {message}");
                }
                sw.WriteLine("-------------------------------------------------");
            }
        }
    }
}
