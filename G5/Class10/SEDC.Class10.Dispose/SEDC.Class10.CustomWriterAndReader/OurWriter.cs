using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class10.CustomWriterAndReader
{
    public class OurWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposedValue = false;

        public OurWriter(string path)
        {
            _path = path;
            _sw = new StreamWriter(path, true);
        }

        public void Writer(string text)
        {
            if(text == "brake" || text == "stop")
            {
                throw new Exception("We shouldn't write to file stop or brake.");
            }
            //simulate that we use some resource and we don't dispose the connection to it
            _sw.WriteLine(text);
        }

        //Because we have a method in our class that keeps some resources in use, we must have a Dispose method
        //in our class, we must implement IDisposable interface
        public void Dispose()
        {
            if (!_disposedValue)
            {
                _sw.Dispose();
                //we use this flag just to make sure that we don't call the Dispose implementation several times on the same object
                _path = "";
                _disposedValue = true;
            }
        }
    }
}
