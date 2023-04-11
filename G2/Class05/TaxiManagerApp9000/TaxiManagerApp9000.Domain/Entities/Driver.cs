using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Domain.Entities
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public Shift Shift { get; set; }

        public string License { get; set; } = string.Empty;

        public DateTime LicenseExpiryDate { get; set; }

        public Car Car { get; set; }

        public Driver(string firstName, string lastName, Shift shift, string license, DateTime licenseExpiryDate, Car car)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            License = license;
            LicenseExpiryDate = licenseExpiryDate;
            Car = car;
        }

        public override string Print()
        {
            return $"Driver {FirstName} {LastName} with license number {License} that expires on {LicenseExpiryDate.Month}/{LicenseExpiryDate.Year} drives the car {Car.Model}.";
        }
    }
}
