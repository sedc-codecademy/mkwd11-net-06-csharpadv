using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;

namespace TaxiManager.Domain.Models
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Shift Shift { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpieryDate { get; set; }

        private Car _car;
        public Car Car 
        { 
            get => _car; 
            set
            {
                if (value != null && _car == null)
                {
                    value.DriversAssigned.Add(this);
                }
                else if (value == null && _car != null) 
                {
                    _car.DriversAssigned.Remove(this);
                }

                _car = value;
            }
        }

        public Driver() { }
        public Driver(string firstName,
                      string lastName,
                      Shift shift,
                      string license,
                      DateTime expieryDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            License = license;
            LicenseExpieryDate = expieryDate;
        }

        public override string Print()
        {
            var model = Car == null ? "/" : Car.Model;

            //string model = "";

            //if (Car == null)
            //{
            //    model = "/";
            //}
            //else 
            //{
            //    model = Car.Model;
            //}

            return $"{FullName} driving in the {Shift} shift with a {model} car";
        }
        public ExpieryStatus IsLicenseExpired() 
        {
            if (DateTime.Today >= LicenseExpieryDate)
            {
                return ExpieryStatus.Expired;
            }
            else if (DateTime.Today.AddMonths(3) >= LicenseExpieryDate)
            {
                return ExpieryStatus.Warning;
            }
            else
            {
                return ExpieryStatus.Valid;
            }
        }
    }
}
