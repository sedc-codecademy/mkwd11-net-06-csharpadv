//Synchronous
void SendMessages()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(2000);
    Console.WriteLine("First message");
    Thread.Sleep(2000);
    Console.WriteLine("Second message");
    Thread.Sleep(2000);
    Console.WriteLine("Third message");
    Console.WriteLine("All messages recieved");
}

//SendMessages();

void SendMessagesAsync()
{
    Console.WriteLine("Async getting ready...");

    Thread myThread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nFirst ASYNC message recieved\n");
        Console.ResetColor();
    });

    myThread.Start();

    new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nSecond ASYNC message recieved\n");
        Console.ResetColor();
    }).Start();

    new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThird ASYNC message recieved\n");
        Console.ResetColor();
    }).Start();
    SendMessages();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("All ASYNC messages recieved !!!");
    Console.ResetColor();
}

SendMessagesAsync();