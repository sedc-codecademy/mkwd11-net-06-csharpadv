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
    public class UserGood // If no access modifier specified by default it will be internal (classes)
    {
        private readonly string _userPath = @"C:\users";
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLogged { get; set; } // If no access modifier specified by default it will be private (props)

        public void PrintUser()
        {
            // code ..
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
        // Code ...
    }

    // Good Exception Example
    // Continue Here ...
    public class LoginException : Exception
    {
        // Code ...
    }





    // Interfaces
    // Bad Example
    public interface Vehicle
    {
        public void Drive();
    }

    // Good Interface Example
    // Continue Here ...

    public interface IVehicle
    {
        void Drive();
    }
}
