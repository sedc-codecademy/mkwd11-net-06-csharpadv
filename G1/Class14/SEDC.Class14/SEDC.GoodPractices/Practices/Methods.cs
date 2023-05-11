using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.GoodPractices.Practices
{
    public class Services
    {
        public List<int> numbers = new List<int>();

        public void GetStats()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("You entered");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("========= STATS =========");
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"There are {even} even numbers");

            int odd = numbers.Where(x => x % 2 != 0).Count();
            Console.WriteLine($"There are {odd} odd numbers");

            int positive = numbers.Where(x => x > 0).Count();
            Console.WriteLine($"There are {positive} positive numbers");

            int negative = numbers.Where(x => x < 0).Count();
            Console.WriteLine($"There are {negative} negative numbers");

            int sum = numbers.Sum();
            Console.WriteLine($"The sum of all numbers is {sum}");
        }
    }


    public class NumberService
    {
        public List<int> RequestNumbers(int number)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            return numbers;
        }

        public void PrintStats(List<int> numbers)
        {
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"There are {even} even numbers");

            int odd = numbers.Where(x => x % 2 != 0).Count();
            Console.WriteLine($"There are {odd} odd numbers");

            int positive = numbers.Where(x => x > 0).Count();
            Console.WriteLine($"There are {positive} positive numbers");

            int negative = numbers.Where(x => x < 0).Count();
            Console.WriteLine($"There are {negative} negative numbers");

            int sum = numbers.Sum();
            Console.WriteLine($"The sum of all numbers is {sum}");
        }
    }

    public class ListHelper
    {
        public void PrintListInOneLine<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
        }
    }


    public static class AppService
    {
        private static NumberService _numberService;
        private static ListHelper _listHelper;


        static AppService()
        {
            _listHelper = new ListHelper();
            _numberService = new NumberService();
        }

        public static void AppInit()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");
            List<int> numbers = _numberService.RequestNumbers(5);

            Console.WriteLine("You entered");
            _listHelper.PrintListInOneLine(numbers);

            Console.WriteLine("====== STATS =======");
            _numberService.PrintStats(numbers);
        }
    }
}
