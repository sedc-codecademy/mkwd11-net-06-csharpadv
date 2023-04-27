//void SendMessage()
//{
//    Console.WriteLine("Sending a message...");
//    Thread.Sleep(5000); //simualte wait
//    Console.WriteLine("The message was sent");
//}

////synchronous
////Another code has to wait for all the code from SendMessage to be executed (5+ seconds)
////if the part with Another code message is independent, it doesn't have to wait. In that case only 
//// Console.WriteLine("The message was sent"); has to wait 5 seconds.
//SendMessage();
//Console.WriteLine("Another code...");



async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending a meesage..."); //part of main thread

    //the code in the task is sent away to be executed on another thread
    //The code on line 29 won't be executed until this task finishes (5 seconds)
    //because the code in the task is sent away, at that moment the main thread is free
    await Task.Run(() =>
    {
        Thread.Sleep(5000); //simulate extensive operation that lasts 5 seconds
        Console.WriteLine($"Message: {message}");
    });

    Console.WriteLine("The message was sent"); //part of main thread

    return;
}

void ShowAd(string product)
{
    Console.WriteLine("While you are waiting for the message to be sent, let us show you an ad");
    Console.WriteLine($"You can have this product {product} in the next 10 minutes...");
}

//because there is code that is awaited in this method it makes the main thread free and  the main thread continues with execution of ShowAd
SendMessageAsync("Hello SEDC");
ShowAd("C# course");

//if you want the whole code on the main thread to wait for the awaited code, we put await in front of the async method
//await SendMessageAsync("Hello SEDC");
//ShowAd("C# course");

Console.ReadLine();
