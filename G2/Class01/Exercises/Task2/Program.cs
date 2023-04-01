List<DateTime> holidays = new List<DateTime>() {
    new DateTime(DateTime.Now.Year,1,1),
    new DateTime(DateTime.Now.Year,1,7),
    new DateTime(DateTime.Now.Year,4,20),
    new DateTime(DateTime.Now.Year,4,30),
    new DateTime(DateTime.Now.Year,5,1),
    new DateTime(DateTime.Now.Year,5,3),
    new DateTime(DateTime.Now.Year,5,25),
    new DateTime(DateTime.Now.Year,8,2),
    new DateTime(DateTime.Now.Year,9,8),
    new DateTime(DateTime.Now.Year,10,12),
    new DateTime(DateTime.Now.Year,10,23),
    new DateTime(DateTime.Now.Year,12,8),
    new DateTime(DateTime.Now.Year,12,10)
};

while (true)
{
    Console.WriteLine("Please enter a date for check in the format day/month/year");
    string inputDate = Console.ReadLine();

    if (string.IsNullOrEmpty(inputDate))
    {
        Console.WriteLine("Please enter a date!\nPress enter to continue");
        Console.ReadKey();
        continue;
    }

    bool dateParseValidation = DateTime.TryParse(inputDate, out DateTime date);

    if (!dateParseValidation)
    {
        Console.WriteLine("Please enter a valid date!\nPress enter to continue");
        Console.ReadKey();
        continue;
    }

    if (holidays.Any(x => x.Day == date.Day && x.Month == date.Month))
    {
        Console.WriteLine("It's a holiday, so it's a nonworking day!!!\nYou can code the whole day, please exaust yourself !!! Or intoxicate yourself !");
        continue;
    }

    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
    {
        Console.WriteLine("It's a weekend, so it's a nonworking day!!!\nYou can code the whole day, please exaust yourself !!! Or intoxicate yourself !");
        continue;
    }

    Console.WriteLine("Working day. It is what it is...");

    Console.WriteLine("Do you want to check another date?\nType Yes/No");
    if (Console.ReadLine().ToLower() == "no")
    {
        break;
    }
}