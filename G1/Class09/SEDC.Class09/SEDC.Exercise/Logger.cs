using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Exercise
{
    public class Logger
    {
        public static void Log(int first, int second, Operation op, int result)
        {
            var message = $"{DateTime.Now.ToLongTimeString()}: {first} {op} {second} = {result}";
            File.AppendAllLines("log.txt", new List<string> { message });
        }
    }
}
