try
{
    List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(DateTime.Now.Year, 1, 1),
                new DateTime(DateTime.Now.Year, 1, 7),
                new DateTime(DateTime.Now.Year, 4, 17),
                new DateTime(DateTime.Now.Year, 4, 30),
                new DateTime(DateTime.Now.Year, 5, 1),
                new DateTime(DateTime.Now.Year, 5, 3),
                new DateTime(DateTime.Now.Year, 5, 24),
                new DateTime(DateTime.Now.Year, 8, 2),
                new DateTime(DateTime.Now.Year, 9, 8),
                new DateTime(DateTime.Now.Year, 10, 11),
                new DateTime(DateTime.Now.Year, 10, 23),
                new DateTime(DateTime.Now.Year, 12, 8)
            };


    Console.WriteLine("Enter a date in the following format: mm/dd/yyyy");

    //the best is to use TryParse
    DateTime date = DateTime.Parse(Console.ReadLine());

    if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
    {
        Console.WriteLine("Weekend!");
    }
    //check if there is any member in holidays collection, which fulfills the condition. Returns true/false
    else if (holidays.Any(x => x.Day == date.Day && x.Month == date.Month)) 
    {
        Console.WriteLine("Non-working day!");
    }
    else
    {
        Console.WriteLine("Working day :(");
    }

}
catch(Exception e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}


