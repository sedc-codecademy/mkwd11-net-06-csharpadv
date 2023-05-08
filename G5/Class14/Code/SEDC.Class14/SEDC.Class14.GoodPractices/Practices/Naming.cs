namespace SEDC.Class14.GoodPractices.Practices
{
    // Classes
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

    // Good Class Example
    // Continue Here ...




    // Exceptions
    // Bad Example
    class LoginProblem : Exception
    {
        // Code ...
    }

    // Good Exception Example
    // Continue Here ...




    // Interfaces
    // Bad Example
    public interface Vehicle
    {
        public void Drive();
    }

    // Good Interface Example
    // Continue Here ...




}
