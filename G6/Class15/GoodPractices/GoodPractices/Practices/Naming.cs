namespace GoodPractices.Practices
{
    // Bad Example
    class user
    {
        private readonly string userspath = @"C:\users";
        public int id;
        public string name;
        public bool logged;
        public void printuser()
        {
            // ...code
        }
        public void changeid(int NewID)
        {
            id = NewID;
        }
    }

    // Good Example
    class User
    {
        private readonly string _userPath = @"C:\users";
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLoggedIn { get; set; }
        public void PrintUser()
        {
            // ...code
        }
        public void ChangeId(int newId)
        {
            Id = newId;
        }
    }

    // Exceptions
    // Bad Example
    class LoginProblem : Exception
    {
        // ...code
    }
    // Good Example
    class LoginException : Exception
    {
        // ...code
    }

    // Interfaces
    // Bad Example
    public interface Vehicle
    {
        void Drive();
    }

    // Good Example
    public interface +
    {
        void Drive();
    }
}
