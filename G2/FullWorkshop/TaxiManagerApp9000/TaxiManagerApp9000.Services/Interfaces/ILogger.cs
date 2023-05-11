namespace TaxiManagerApp9000.Services.Interfaces
{
    public interface ILogger
    {
        void Log(string logType, string error, string message, string username);
    }
}
