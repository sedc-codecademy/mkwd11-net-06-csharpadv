
// RUNNING THREADS IN PARALLEL
// If you have X amount of logical processors you can process X amount of threads simultaneously.
// The rest will queue up and wait their turn.



// Ex.
// You have 16 operations, methods, etc.. (each takes 200ms to run)

// Synchronously it will take 3200ms
// On 8 Core Processor ( 16 Threads ) this operation will finish in 200ms
// On 4 Core Processor ( 8 Threads ) this operation will finish in 400ms
// On 2 Core Processor ( 4 Threads ) this operation will finish in 800ms


// Synchronous
void SendMessages()
{
    Console.WriteLine("[Sync] Getting ready...");

    Thread.Sleep(2000);

    Console.WriteLine("[Sync] First message arrived!");

    Thread.Sleep(2000);

    Console.WriteLine("[Sync] Second message arrived!");

    Thread.Sleep(2000);

    Console.WriteLine("[Sync] Third message arrived!");
    Console.WriteLine("[Sync] All messages are received!");
}

// Asynchronous using Thread
void SendMessagesWithThreads()
{
    Console.WriteLine("[Async] Getting ready...");

    Thread myThread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("[Async] First message arrived!");
    });
    myThread.Name = "My First Thread";
    myThread.Start();

    new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("[Async] Second message arrived!");
    }).Start();

    new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("[Async] Third message arrived!");
    }).Start();

    Console.WriteLine("[Async] All messages are received!");
}

SendMessages();
SendMessagesWithThreads();



// We have two types of threads
// - Foreground Threads
// - Background Threads

// When you create a new thread, by default it is created as a foreground thread.
// Foreground threads keep the application running until they finish executing.

//  The application is going to run until all foreground threads are finished
//  Background threads do not keep the application running

//  If all foreground threads have finished executing, the application will finish even if there are still background threads running.

Thread myForegroundThread = new Thread(() =>
{
    Thread.Sleep(2500);
    Console.WriteLine("Foreground thread finished!");
});

Thread myBackgroundThread = new Thread(() =>
{
    Thread.Sleep(2500);
    Console.WriteLine("Background thread finished!");
});
myBackgroundThread.IsBackground = true;



myBackgroundThread.Start();
myForegroundThread.Start();

// If we do not freeze the app, the application will finish because the only foreground thread we have is our Main Thread.
Console.WriteLine($"Is Main Thread a background thread: {Thread.CurrentThread.IsBackground}");

Console.ReadKey();