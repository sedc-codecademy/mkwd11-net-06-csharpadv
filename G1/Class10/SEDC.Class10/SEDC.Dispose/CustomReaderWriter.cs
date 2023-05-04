namespace SEDC.Dispose
{
    public class OurWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposed;

        public OurWriter(string path)
        {
            _path = path;
            _sw = new StreamWriter(_path, true);
        }

        
        public void Write(string text)
        {
            if (text == "break")
                throw new Exception("Something broke unexpectedly...");
            _sw.WriteLine(text);
        }

        // We implement this private method that will remember when this class is disposed
        // That way, if the same calss tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if(!_disposed)
            {
                _sw.Dispose();
            }
            _path = "";
            _disposed = true;
        }
        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            _dispose(true);
            //_sw.Dispose();
        }
    }

    public class OurReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool _disposed;


        public OurReader(string path)
        {
            _path = path;
            _sr = new StreamReader(_path);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        // We implement this private method that will remember when this class is disposed
        // That way, if the same calss tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!_disposed)
            {
                _sr.Dispose();
            }
            _path = "";
            _disposed = true;
        }
        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            _dispose(true);
            //_sr.Dispose();
        }

    }

}
