using SEDC.Class09.Logger.Services;

namespace SEDC.Class09.Logger.CustomExceptions
{
    public class InvalidLoginException : Exception
    {
        private LoggerService _loggerService = new LoggerService();

        public InvalidLoginException(string username) : base("User entered wrong username or password!")
        {
            Username = username;
            _loggerService.LogError();
        }

        public string Username { get; set; }
    }
}
