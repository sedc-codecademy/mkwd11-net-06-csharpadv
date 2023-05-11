namespace SOLID
{
    /*
            *** INTERFACE SEGREGATION PRINCIPLE ***
            
            => No class (service class for example) should be forced to implement methods that it does not use.
            => The contracts (interfaces) should be broken down into thin ones.

     */

    class TaxiUser
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    class TaxiDriver
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    class TaxiCar
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? LicensePlate { get; set; }
    }

    #region WithoutISP
    // BAD EXAMPLE
    interface ITaxiService
    {
        bool Login(string username, string password);
        int Register(TaxiUser user);
        List<TaxiUser> GetAllUsers();
        List<TaxiDriver> GetAllDrivers();
        List<TaxiCar> GetAllCars();
        void GetAllLicensePlates();
    }

    class UserServiceISP : ITaxiService
    {
        public List<TaxiUser> GetAllUsers()
        {
            // code...
            return new List<TaxiUser>();
        }

        public bool Login(string username, string password)
        {
            // code...
            return true;
        }

        public int Register(TaxiUser user)
        {
            // code...
            return user.Id;
        }

        public List<TaxiCar> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public List<TaxiDriver> GetAllDrivers()
        {
            throw new NotImplementedException();
        }

        public void GetAllLicensePlates()
        {
            throw new NotImplementedException();
        }
    }

    class DriverServiceISP : ITaxiService
    {
        public List<TaxiDriver> GetAllDrivers()
        {
            // code ...
            return new List<TaxiDriver>();
        }

        public List<TaxiCar> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public void GetAllLicensePlates()
        {
            throw new NotImplementedException();
        }

        public List<TaxiUser> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public int Register(TaxiUser user)
        {
            throw new NotImplementedException();
        }
    }


    #endregion

    #region WithISP
    // GOOD EXAMPLE
    interface IUserService
    {
        bool Login(string username, string password);
        int Register(TaxiUser user);
        List<TaxiUser> GetAllUsers();
    }

    interface IDriverService
    {
        List<TaxiDriver> GetAllDrivers();
    }

    interface ICarService
    {
        List<TaxiCar> GetAllCars();
        void GetAllLicensePlates();
    }

    class UserServiceIsP : IUserService
    {
        public List<TaxiUser> GetAllUsers()
        {
            // code...
            return new List<TaxiUser>();
        }

        public bool Login(string username, string password)
        {
            // code...
            return true;
        }

        public int Register(TaxiUser user)
        {
            // code...
            return user.Id;
        }
    }

    class DriverServiceIsP : IDriverService
    {
        public List<TaxiDriver> GetAllDrivers()
        {
            // code...
            return new List<TaxiDriver>();
        }
    }
    #endregion
}
