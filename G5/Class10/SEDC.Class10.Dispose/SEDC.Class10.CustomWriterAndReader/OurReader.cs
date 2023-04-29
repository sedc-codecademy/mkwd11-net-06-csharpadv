using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class10.CustomWriterAndReader
{
    public class OurReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool _disposedValue = false;

        public OurReader(string path)
        {
            _path = path;
            _sr = new StreamReader(path);
        }

        public string Reader()
        {
            //simulate that we use some resource and we don't dispose the connection to it
            return _sr.ReadToEnd();
        }

        //Because we have a method in our class that keeps some resources in use, we must have a Dispose method
        //in our class, we must implement IDisposable interface
        public void Dispose()
        {
            if (!_disposedValue)
            {
                _sr.Dispose();
                //we use this flag just to make sure that we don't call the Dispose implementation several times on the same object
                _path = "";
                _disposedValue = true;
            }
            
        }
    }
}
