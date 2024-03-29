﻿using System;
using System.Runtime.InteropServices;

namespace SEDC.Class14.GoodPractices.Practices
{
    // Bad Example
    public class Service
    {
        public List<int> numbers = new List<int>();
        public void GetStats()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("You entered: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Stats:");

            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }

    // Continue here ...


    public class NumberService
    {
        public List<int> RequestNumbers(int number)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter number:");
                result.Add(int.Parse(Console.ReadLine()));
            }

            return result;
        }

        public void PrintStats(List<int> numbers)
        {
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }

    public static class ListHelper
    {
        public static void PrintList<T>(List<T> list)
        {
            foreach (T listItem in list)
            {
                Console.Write(listItem + " ");
            }
            Console.WriteLine();
        }
    }

    public class MethodsApp
    {
        private readonly NumberService _numService;
        private List<int> _numbers;

        public MethodsApp()
        {
            _numService = new NumberService();
            _numbers = new List<int>();
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");
            _numbers = _numService.RequestNumbers(5);
            Console.Write("You entered: ");
            ListHelper.PrintList(_numbers);
            Console.WriteLine("Stats:");
            _numService.PrintStats(_numbers);
        }
    }
}
