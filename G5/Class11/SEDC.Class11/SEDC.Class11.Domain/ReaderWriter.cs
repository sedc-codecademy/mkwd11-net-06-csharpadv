using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class11.Domain
{
    public class ReaderWriter
    {
        public void Writer(string path, string text)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text);
            }
        }

        public string Reader(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"File on path {path} does not exist");
            }

            string result = "";
            using(StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }
    }
}
