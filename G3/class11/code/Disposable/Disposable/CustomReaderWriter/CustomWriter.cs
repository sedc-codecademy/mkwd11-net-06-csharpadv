using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable.CustomReaderWriter
{
    public class CustomWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposedValue = false;

        public CustomWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(filePath, true);
        }

        public void Write(string text) 
        {
            if (text == "break") 
            {
                throw new Exception("Something broke unexpectedly..");
            }

            _sw.WriteLine(text);
        }

        private void _dispose(bool disposing) 
        {
            if (!_disposedValue) 
            {
                if (disposing) 
                {
                    _sw.Dispose();
                }
            }

            _path = "";
            _disposedValue = true;
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }
}
