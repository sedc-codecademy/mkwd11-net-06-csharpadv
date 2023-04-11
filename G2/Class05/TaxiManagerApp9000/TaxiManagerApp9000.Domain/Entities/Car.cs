namespace TaxiManagerApp9000.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; } = string.Empty;

        public string LicensePlate { get; set; } = string.Empty;

        public DateTime LicensePlateExpiryDate { get; set; }

        public List<Driver> AssignedDrivers { get; set; } = new List<Driver>();

        public Car(string model, string licensePlate, DateTime licensePlateExpiryDate, List<Driver> assignedDrivers)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = licensePlateExpiryDate;
            AssignedDrivers = assignedDrivers;
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
    }
}
