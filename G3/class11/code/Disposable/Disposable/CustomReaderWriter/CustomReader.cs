using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable.CustomReaderWriter
{
    public class CustomReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool _disposedValue = false;

        public CustomReader(string filePath)
        {
            _path = filePath;
            _sr = new StreamReader(filePath);
        }

        public string Read() 
        {
            return _sr.ReadToEnd();
        }

        private void _dispose(bool disposing) 
        {
            if (!_disposedValue) 
            {
                if (disposing) 
                {
                    _sr.Dispose();
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
