namespace Disposable
{
    public class OurWriter : IDisposable
    {
        private string _path;

        private StreamWriter _sw;

        private bool disposedValue = false;

        public OurWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(_path, true);
        }

        private void _dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
            }
            _path = "";
            disposedValue = true;
        }

        public void Dispose()
        {
            _dispose(true);
        }

        public void Write(string text)
        {
            if (text == "break") throw new Exception("Something went wrong!");
            _sw.WriteLine(text);
        }
    }

    public class OurReader : IDisposable
    {
        private string _path;

        private StreamReader _sr;

        private bool disposedValue = false;

        public OurReader(string filePath)
        {
            _path = filePath;
            _sr = new StreamReader(_path);
        }

        private void _dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }
            }
            _path = "";
            disposedValue = true;
        }

        public void Dispose()
        {
            _dispose(true);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }
    }
}
