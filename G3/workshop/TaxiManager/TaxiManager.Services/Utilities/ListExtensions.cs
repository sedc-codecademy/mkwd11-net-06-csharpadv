using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;

namespace TaxiManager.Services.Utilities
{
    public static class ListExtensions
    {
        private static readonly Dictionary<ExpieryStatus, ConsoleColor> StatusColorMap =
            new Dictionary<ExpieryStatus, ConsoleColor>()
            {
                { ExpieryStatus.Valid, ConsoleColor.Green },
                { ExpieryStatus.Warning, ConsoleColor.Yellow },
                { ExpieryStatus.Expired, ConsoleColor.Red }
            };
        public static void Print<T>(this List<T> list) where T : BaseEntity 
        {
            if (list.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<T>();
            }
            else 
            {
                foreach (var item in list) 
                {
                    Console.WriteLine(item.Print());
                }
            }

            Console.ReadLine();
        }
        public static void PrintStatus(this List<Car> cars) 
        {
            if (cars.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<Car>();
            }
            else 
            {
                foreach (var car in cars)
                {
                    ExpieryStatus status = car.IsLicensePlateExpired();
                    ExtendedConsole.Write($"[{status}]", StatusColorMap[status]);
                    Console.WriteLine(
                        $"Car Id: {car.Id} - Plate: {car.LicensePlate} with expiery date: {car.LicensePlateExpieryDate}");
                }
            }

            Console.ReadLine();
        }
        public static void PrintStatus(this List<Driver> drivers) 
        {
            if (drivers.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<Driver>();
            }
            else 
            {
                foreach (var driver in drivers) 
                {
                    ExpieryStatus status = driver.IsLicenseExpired();
                    ExtendedConsole.Write($"[{status}]", StatusColorMap[status]);
                    Console.WriteLine(
                        $"Driver: {driver.FullName} with license {driver.License} with expiery date {driver.LicenseExpieryDate}");
                }
            }

            Console.ReadLine();
        }
    }
}
