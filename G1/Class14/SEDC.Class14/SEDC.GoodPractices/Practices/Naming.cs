using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.GoodPractices.Practices
{
    #region Classes, methods, properties and private fields
    //Bad example
    public class user
    {
        private readonly string userpath = @"C:\Users";
        public int id { get; set; }
        public string name { get; set; }
        public bool logged { get; set; }
        public void printuser()
        {
            //some code that prints user info
        }

        public void changeid(int NewID)
        {
            id = NewID;
        }
    }

    // Good example
    public class User
    {
        private readonly string _userPath = @"C:\Users";

        public const string ADMIN_ROLE = "Administrator";
        public const string CUSTOMER_ROLE = "Customer";


        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsLogged { get; set; }

        public void PrintUser()
        {
            // some code that prints user info
        }
    }
    #endregion


    #region Exceptions
    //Exceptions
    //Bad example

    public class LoginProblem : Exception
    {
        // ... code
    }

    //Good example
    public class LoginException : Exception
    {
        // ... code
    }
    #endregion

    #region Interfaces
    //Bad example
    public interface Vehicle
    {
        void Drive();
    }

    //Good example
    public interface IVehicle
    {
        void Drive();
    }


    #endregion
}
