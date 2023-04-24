using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposingClasses
{
    public class CustomWriter : IDisposable
    {
        private string _filePath;
        private StreamWriter _sw;

        private bool _isDisposed = false;

        public CustomWriter(string filePath)
        {
            _filePath = filePath;
            _sw = new StreamWriter(filePath, true);
        }

        public void Write(string text)
        {
            if(text == "stop")
            {
                throw new Exception("We shouldn't write to file....");
            }
            //simulate that we use some resource and we don't dispose the connection to it
            _sw.WriteLine(text);
        }

        //Because we have a method in our class that keeps some resources in use, we must have a Dispose method
        //in our class, we must implement IDisposable interface
        public void Dispose()
        {
            if(! _isDisposed)
            {
                _sw.Dispose();
                //we use this flag just to make sure that we don't call the Dispose implementation several times on the same object
                _isDisposed = true;
            }
        }
    }
}
