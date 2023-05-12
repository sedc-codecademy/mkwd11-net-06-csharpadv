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

        public override string Print()
        {
            return $"{Model} with License Plate {LicensePlate}";
        }

        public ExpieryStatus IsLicenseExpired() 
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
