using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.DomainModels.Enums;

namespace TaxiManager.DomainModels.Models
{
    public class Driver : BaseEntity
    {
        public Driver() { }

        public Driver(string firstName, string lastName, Shift shift, Car car, string license, DateTime expieryDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            License = license;
            LicenseExpieryDate = expieryDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public Car Car { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpieryDate { get; set; }

        public ExpieryStatus IsLicenseExpired()
        {
            if (DateTime.Today >= LicenseExpieryDate)
                return ExpieryStatus.Expired;
            else if (DateTime.Today.AddMonths(3) >= LicenseExpieryDate)
                return ExpieryStatus.Warning;
            return ExpieryStatus.Valid;
        }

        public override string Print()
        {
            string model = Car == null ? "/" : Car.Model;
            return $"{FirstName} {LastName} Driving in the {Shift} shift with a {model} car.";
        }
    }
}
