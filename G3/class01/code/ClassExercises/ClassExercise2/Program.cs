List<DateTime> holidays = new List<DateTime>()
{
    new DateTime(DateTime.Now.Year, 1, 1),
    new DateTime(DateTime.Now.Year, 1, 7),
    new DateTime(DateTime.Now.Year, 4, 20),
    new DateTime(DateTime.Now.Year, 5, 1),
    new DateTime(DateTime.Now.Year, 5, 25),
    new DateTime(DateTime.Now.Year, 8, 3),
    new DateTime(DateTime.Now.Year, 9, 8),
    new DateTime(DateTime.Now.Year, 10, 12),
    new DateTime(DateTime.Now.Year, 10, 23),
    new DateTime(DateTime.Now.Year, 12, 8),
};

while (true) 
{
    try
    {
        Console.WriteLine("Please enter a date for check in format month/day/year:");
        string input = Console.ReadLine();

        string[] date = input.Split("/");

        if (date.Length != 3)
        {
            throw new Exception("Wrong input for date");
        }

        int[] dateSegment = new int[3];

        for (int i = 0; i < date.Length; i++)
        {
            bool successParse = int.TryParse(date[i], out int segment);

            if (!successParse)
            {
                throw new Exception("Wrong input for date");
            }

            dateSegment[i] = segment;
        }

        DateTime selectDate = new DateTime(dateSegment[2], dateSegment[0], dateSegment[1]);

        if (selectDate.DayOfWeek == DayOfWeek.Saturday || selectDate.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Not working day");
            continue;
        }

        if (holidays.Any(date => date.Day == selectDate.Day && date.Month == selectDate.Month))
        {
            Console.WriteLine("Not working day");
            continue;
        }

        Console.WriteLine("Working day");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


