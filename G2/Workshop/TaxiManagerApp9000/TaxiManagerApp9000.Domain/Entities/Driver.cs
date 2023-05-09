using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Domain.Entities
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public Shift Shift { get; set; }

        public int? CarId { get; set; }

        public string License { get; set; } = string.Empty;

        public DateTime LicenseExpiryDate { get; set; }

        public Car Car { get; set; }

        public Driver(string firstName, string lastName, Shift shift, int? carId, string license, DateTime licenseExpiryDate)
        {
            FirstName = firstName;
            LastName = lastName;
            CarId = carId;
            Shift = shift;
            License = license;
            LicenseExpiryDate = licenseExpiryDate;
        }

        public override string Print()
        {
            return $"Driver {FirstName} {LastName} with license number {License} that expires on {LicenseExpiryDate.Month}/{LicenseExpiryDate.Year} drives the car {Car.Model}.";
        }

        public ExpiryStatus IsLicenseExpired()
        {
            if (DateTime.Today >= LicenseExpiryDate)
            {
                return ExpiryStatus.Expired;
            }
            else if (DateTime.Today.AddMonths(3) >= LicenseExpiryDate)
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
