#region Sync

void MakeTea()
{
    var boiledWater = BoilWater();

    Console.WriteLine("Take the cups out");

    Console.WriteLine("Put tea in cups");

    Console.WriteLine($"Pour {boiledWater} in cups");
}

string BoilWater()
{
    Console.WriteLine("Start the kettle");

    Console.WriteLine("Waiting for the kettle");

    Thread.Sleep(2000);

    Console.WriteLine("Kettle finished boiling");

    return "water";
}

#endregion

#region Async
// Adding Async to methods - convention
async Task MakeTeaAsync()
{
    var boilingWater = BoilWaterAsync();

    Console.WriteLine("Take the cups out");

    Console.WriteLine("Put tea in cups");

    var boiledWater = await boilingWater;

    Console.WriteLine($"Pour {boiledWater} in cups");
}

async Task<string> BoilWaterAsync()
{
    Console.WriteLine("Start the kettle");

    Console.WriteLine("Waiting for the kettle");

    // await => non blocking - Does not block the Main Thread - Our method will continue back inside MakeTeaAsync
    await Task.Run(async () =>
    {
        await Task.Delay(5000);
        Console.WriteLine("Kettle finished boiling");
    });

    // GetAwaiter().GetResult() => Blocks the Main Thread - Our method will not continue back inside MakeTeaAsync
    //Task.Run(() =>
    //{
    //    Thread.Sleep(5000);
    //    Console.WriteLine("Kettle finished boiling");
    //}).GetAwaiter().GetResult();

    return "water";
}

#endregion


//MakeTea();

MakeTeaAsync();

Console.ReadKey();

