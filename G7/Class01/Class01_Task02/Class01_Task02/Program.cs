namespace Class01_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October, and 8 December
            //01.01.1999
            List<DateTime> nonWorkingDays = new List<DateTime>
            {
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 4, 20),
                new DateTime(2023, 5, 1),
                new DateTime(2023, 5, 25),
                new DateTime(2023, 8, 3),
                new DateTime(2023, 9, 8),
                new DateTime(2023, 10, 12),
                new DateTime(2023, 10, 23),
                new DateTime(2023, 12, 8)
            };

            //List<string> non = new List<string>
            //{
            //    "01.01",
            //    "07.01"
            //}

            while (true)
            {
                Console.WriteLine("Please choose the input format for the date");
                Console.WriteLine("1. Complete date (DD.MM.YYYY)");
                Console.WriteLine("2. Separate vaules");

                string choiceInput = Console.ReadLine();

                if (choiceInput != "1" && choiceInput != "2")
                {
                    Console.WriteLine("Wrong input for date type choice.");
                    continue;
                }

                DateTime date = DateTime.MinValue;

                switch (choiceInput)
                {
                    case "1":
                        {
                            date = ProcedureForInsertingFullDate();

                            if (date == DateTime.MinValue)
                            {
                                continue;
                            }
                            break;
                        }
                    case "2":
                        {
                            date = ProcedureForInsertingSeparteDate();

                            if (date == DateTime.MinValue)
                            {
                                continue;
                            }
                            break;
                        }
                }

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.Write($"{date.ToString("dd.MM.yyyy")} is weekend");
                }
                else if (nonWorkingDays.Any(x => x.Day == date.Day && x.Month == date.Month))
                {
                    Console.WriteLine($"{date.ToString("dd.MM.yyyy")} is a holiday");
                }
                else
                {
                    Console.WriteLine($"{date.ToString("dd.MM.yyyy")} is working day");
                }

                Console.WriteLine("If you want to enter new date please insert Y/y");
                string input = Console.ReadLine();

                if(input != "Y" && input != "y")
                {
                    Console.WriteLine("Thank you for using our app");
                    break;
                }
            }
        }

        static DateTime ProcedureForInsertingFullDate()
        {
            Console.WriteLine("Please input the date");
            string dateInput = Console.ReadLine();

            if(!DateTime.TryParse(dateInput, out DateTime date))
            {
                Console.WriteLine("You have inputed wrong date");
                return DateTime.MinValue;
            }

            return date;
        }

        static DateTime ProcedureForInsertingSeparteDate()
        {
            Console.WriteLine("Please input the day");
            string dayInput = Console.ReadLine();
            Console.WriteLine("Please input the month");
            string monthInput = Console.ReadLine();
            Console.WriteLine("Please input the year");
            string yearInput = Console.ReadLine();

            if(!int.TryParse(dayInput, out int day))
            {
                Console.WriteLine("Wrong input for day");
                return DateTime.MinValue;
            }

            if (!int.TryParse(monthInput, out int month))
            {
                Console.WriteLine("Wrong input for month");
                return DateTime.MinValue;
            }

            if (!int.TryParse(yearInput, out int year))
            {
                Console.WriteLine("Wrong input for year");
                return DateTime.MinValue;
            }

            try
            {
                DateTime date = new DateTime(year, month, day);
                return date;
            } catch (Exception ex)
            {
                Console.WriteLine("Invalid date");
                return DateTime.MinValue;
            }
        }
    }
}