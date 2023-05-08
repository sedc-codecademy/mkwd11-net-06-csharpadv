using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserialize.Services
{
    public class FileService
    {
        public string ReadFile(string path) 
        {
            string result = "";

            if (!File.Exists(path)) 
            {
                return "File does not exist!";
            }

            using (StreamReader sr = new StreamReader(path, true)) 
            {
                result = sr.ReadToEnd();
            }

            return result;
        }

        public void WriteFile(string path, string data) 
        {
            using (StreamWriter sw = new StreamWriter(path, false)) 
            {
                sw.WriteLine(data);
            }
        }
    }
}
