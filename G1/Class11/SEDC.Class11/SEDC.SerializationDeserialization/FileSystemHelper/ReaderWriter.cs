namespace SEDC.SerializationDeserialization.FileSystemHelper
{
    public static class ReaderWriter
    {
        public static string ReadFile(string filePath)
        {
            string result = string.Empty;
            if(!File.Exists(filePath))
            {
                return "File not exist!";
            }
            using (StreamReader sr = new StreamReader(filePath))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

        public static void WriteFile(string filePath, string data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Successfully written in a file!");
        }
    }
}
