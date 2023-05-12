using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;

namespace TaxiManager.Domain.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime LicensePlateExpieryDate{ get; set; }
        public List<Driver> DriversAssigned { get; set; }

        public Car() {}
        public Car(string model,
                   string licensePlate, 
                   DateTime expieryDate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpieryDate = expieryDate;
            DriversAssigned = new List<Driver>();
        }

        public override string Print()
        {
            int assignedPercent = DriversAssigned.Count == 0 ? 0 : 100 / 3 + DriversAssigned.Count + 1;
            return $"{Model} with License Plate {LicensePlate} and utilize {assignedPercent}";
        }
        public ExpieryStatus IsLicensePlateExpired() 
        {
            if (DateTime.Today >= LicensePlateExpieryDate)
            {
                return ExpieryStatus.Expired;
            }
            else if (DateTime.Today.AddMonths(3) >= LicensePlateExpieryDate)
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
