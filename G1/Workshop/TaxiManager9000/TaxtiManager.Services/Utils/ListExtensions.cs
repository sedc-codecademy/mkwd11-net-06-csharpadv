using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.DomainModels.Enums;
using TaxiManager.DomainModels.Models;

namespace TaxiManager.Services.Utils
{
    public static class ListExtensions
    {
        private static readonly Dictionary<ExpieryStatus, ConsoleColor> StatusColorMap = new Dictionary<ExpieryStatus, ConsoleColor>()
        {
            {ExpieryStatus.Valid, ConsoleColor.Green },
            {ExpieryStatus.Expired, ConsoleColor.Red },
            {ExpieryStatus.Warning, ConsoleColor.Yellow }
        };


        public static void Print<T>(this List<T> list) where T : BaseEntity
        {
            if (list.Count == 0)
                ConsoleExtensions.NoItemsMessage<T>();
            else
                foreach (T item in list)
                    Console.WriteLine(item.Print());
            Console.ReadLine();
        }

        public static void PrintStatus(this List<Car> list)
        {
            if(list.Count == 0)
                ConsoleExtensions.NoItemsMessage<Car>();
            else
                foreach (Car car in list)
                {
                    ExpieryStatus status = car.IsLicenseExpired();
                    ConsoleExtensions.Write($"[{status}]", StatusColorMap[status]);
                    ConsoleExtensions.WriteLine($"Car ID: {car.Id} - Plate: {car.LicensePlate} expiering on {car.LicensePlateExpieryDate}");
                }

            Console.ReadLine();
        }

        public static void PrintStatus(this List<Driver> list)
        {
            if(list.Count == 0)
                ConsoleExtensions.NoItemsMessage<Driver>();
            else
                foreach (Driver driver in list)
                {
                    ExpieryStatus status = driver.IsLicenseExpired();
                    ConsoleExtensions.Write($"[{status}]", StatusColorMap[status]);
                    ConsoleExtensions.WriteLine($"Driver {driver.FullName} with license {driver.License} expiering on {driver.LicenseExpieryDate}");
                }
            Console.ReadLine();
        }

    }
}
