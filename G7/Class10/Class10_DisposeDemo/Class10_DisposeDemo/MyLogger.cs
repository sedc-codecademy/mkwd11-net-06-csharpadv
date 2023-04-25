using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_DisposeDemo
{
    public class MyLogger : IDisposable
    {
        private StreamWriter _sw;

        public MyLogger(string path)
        {
            _sw = new StreamWriter(path, true);
        }

        public void LogError(Exception ex)
        {
            _sw.WriteLine($"[{DateTime.Now.ToString()}] Error: {ex.Message}");
        }

        public void Dispose()
        {
            _sw.Dispose();
        }
    }
}
