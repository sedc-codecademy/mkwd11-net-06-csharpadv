using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; } = string.Empty;

        public string LicensePlate { get; set; } = string.Empty;

        public DateTime LicensePlateExpiryDate { get; set; }

        public List<Driver> AssignedDrivers { get; set; } = new List<Driver>();

        public Car(string model, string licensePlate, DateTime licensePlateExpiryDate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = licensePlateExpiryDate;
        }

        public override string Print()
        {
            int counter = 1;
            string drivers = string.Empty;
            foreach (Driver driver in AssignedDrivers)
            {
                drivers += counter + ".) " + driver.FirstName + " " + driver.LastName + "\n";

                counter++;
            }

            return $"Car {Model} with plates {LicensePlate} that expire on {LicensePlateExpiryDate.Month}/{LicensePlateExpiryDate.Year} is driven by:\n{drivers}";
        }

        public ExpiryStatus IsLicenseExpired()
        {
            if (DateTime.Today >= LicensePlateExpiryDate)
            {
                return ExpiryStatus.Expired;
            }
            else if (DateTime.Today.AddMonths(3) >= LicensePlateExpiryDate)
            {
                return ExpiryStatus.Warning;
            }
            else
            {
                return ExpiryStatus.Valid;
            }
        }
    }
}
