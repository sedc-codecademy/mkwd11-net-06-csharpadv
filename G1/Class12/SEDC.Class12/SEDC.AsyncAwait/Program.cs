


void SendMessage(string message)
{
    Console.WriteLine("Sending message....");
    Thread.Sleep(7000);
    Console.WriteLine($"The message {message} was sent!");
}

async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...");
    await Task.Run(() =>
    {
        Thread.Sleep(10000);
        Console.WriteLine($"The message {message} was sent!");
    });
}

void ShowAd(string product)
{
    Console.WriteLine("While waiting let us show you an ad:");
    Thread.Sleep(1000);

    Console.WriteLine("Buy the best product in the world!");
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Thread.Sleep(1000);
    Console.WriteLine(product);

    Console.ResetColor();

    Thread.Sleep(1000);
    Console.WriteLine(" now and get ");

    Console.ForegroundColor = ConsoleColor.Green;

    Thread.Sleep(1000);
    Console.WriteLine("FREE");

    Console.ResetColor();

    Thread.Sleep(1000);
    Console.WriteLine(" shipping worldwide!");
}


async Task MainThread()
{
    // If you await the following method call, it will behave like a sync execution
    // it will block the main thread anyway
    //await SendMessageAsync("Hello there and bye!");

    // If you avoid 'await' in the following method call, this still will behave as async 
    // execution
    SendMessageAsync("Hello there and bye!");
    ShowAd("Potato");
}

//SendMessage("Hello from SEDC!");

//Task task = SendMessageAsync("Hello this is asynchronous message!");
//Console.WriteLine(task.Status);

//Thread.Sleep(2000);
//ShowAd("Potato");


// Making sync with asycn ?!?
//MainThread();







Console.ReadLine();