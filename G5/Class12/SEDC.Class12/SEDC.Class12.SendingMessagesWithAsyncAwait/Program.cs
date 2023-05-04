void SendMessage(string message)
{
    Console.WriteLine("Sending message...");
    MessageSender(message);
}

// Adding Async to methods - convention
async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...");
    await Task.Run(() => MessageSender(message));
}

// This method represents some huge complex message sending process that takes 5sec.
void MessageSender(string message)
{
    Thread.Sleep(5000);
    Console.WriteLine($"The message '{message}' was sent!");
}

void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad:");
    Console.Write("Buy the best product in the world ");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(product);
    Console.ResetColor();
    Console.Write(" now and get ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("FREE");
    Console.ResetColor();
    Console.WriteLine(" shipping worldwide!");
}


// Synchronous execution ( It does not show the add while we wait )
SendMessage("Hello G5");

// Asynchronous execution ( It shows the ad while we wait )
SendMessageAsync("Hello G5");

ShowAd("Biscuits");

Console.ReadKey();