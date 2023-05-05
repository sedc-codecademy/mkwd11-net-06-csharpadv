
//Console.WriteLine("App start....");

//Task task = new Task(() =>
//{
//    Thread.Sleep(2000);
//    Console.WriteLine("Running after 2000ms");
//});
//task.Start();



Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("We can now get the number...");
    return 10;
});

Console.WriteLine($"Task status before starting: {valueTask.Status}");
valueTask.Start();
Console.WriteLine($"Task status after starting: {valueTask.Status}");


int numberFromTask = valueTask.Result;
Console.WriteLine(numberFromTask);
Console.WriteLine($"Task status after printing the result: {valueTask.Status}");

Task.Run(() =>
{
    Thread.Sleep(3000);
    Console.WriteLine("This is executed immedietily");
});

Console.WriteLine(valueTask.Result);
Console.WriteLine("App has ended...");



//for (int i = 0; i < 20; i++)
//{
//    int temp = i;
//    Task.Run(() =>
//    {
//        Thread.Sleep(2000);
//        Console.WriteLine($"Task No. {temp}");
//    });
//}
















Console.ReadLine();
