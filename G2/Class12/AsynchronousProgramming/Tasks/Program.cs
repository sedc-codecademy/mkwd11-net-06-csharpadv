//Console.WriteLine("App start !!!");

////Single task example

//Task myTask = new Task(() =>
//{
//    //Thread.Sleep(2000);
//    Console.WriteLine("Running after 2000ms");
//});

//myTask.Start();

//Task<int> valueTask = new Task<int>(() =>
//{
//    //Thread.Sleep(2000);
//    Console.WriteLine("We can now get the number...");
//    return 7;
//});
//valueTask.Start();

//Task.Run(() =>
//{
//    //Thread.Sleep(2000);
//    Console.WriteLine("THIS IS EXECUTED IMMEDIATELY !!!");
//});

//Console.WriteLine(valueTask.Result);
//Console.WriteLine("APP END !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

//Console.ReadLine();

for (int i = 1; i <= 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        //Thread.Sleep(1000);
        Console.WriteLine($"TASK NUMBER {temp}");
    });
}

Console.ReadLine();