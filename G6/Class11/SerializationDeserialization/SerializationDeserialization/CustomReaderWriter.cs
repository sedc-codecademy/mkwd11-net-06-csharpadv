using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    public class CustomReaderWriter
    {
        public string ReadFromFile(string filePath)
        {
            if(!File.Exists(filePath))
            {
                throw new Exception($"File on path {filePath} does not exist");
            }

            string result = "";
            using(StreamReader sr = new StreamReader(filePath))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }

        public void WriteToFile(string filePath, string text)
        {
            using( StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(text);
            }
        }
    }
}
