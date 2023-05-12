Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(3000);
    Console.WriteLine("We can now get the number...");
    return 6;
});

valueTask.Start();



