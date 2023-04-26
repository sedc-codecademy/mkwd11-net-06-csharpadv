namespace Class10_DisposeDemo
{
    public class CustomWriter : IDisposable
    {
        private StreamWriter _sw;

        public CustomWriter(string path)
        {
            _sw = new StreamWriter(path);
        }

        public void WriteLine(string text)
        {
            _sw.WriteLine($"{DateTime.Now.ToString()} - {text}");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose is invoked");
            _sw.Dispose();
        }
    }
}
