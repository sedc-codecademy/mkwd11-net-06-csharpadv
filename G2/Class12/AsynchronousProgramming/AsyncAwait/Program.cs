async Task MainThread()
{
    await SendMessageAsync("HELLO BATINJA BE BATE !!!");
    ShowAd("privezok ob BMW");
    Console.ReadLine();
}

void SendMessage(string message)
{
    Console.WriteLine("Sending message...");
    Thread.Sleep(7000);
    Console.WriteLine("The message " + message + " was sent.");
}

async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending ASYNC message !!!");
    await Task.Run(() =>
    {
        Thread.Sleep(7000);
        Console.WriteLine("The ASYNC message " + message + " was sent.");
    });
}

void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad:");
    Console.WriteLine("Buy the best product in the world!");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(product);
    Console.ResetColor();
    Console.Write(" now and get ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("FREE");
    Console.ResetColor();
    Console.WriteLine(" shipping worldwide !!!");
}

await MainThread();
