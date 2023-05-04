using System.Diagnostics;


//  Task - Some asynchronous work that needs to be done
//  You do not care on what thread this work is going to be done
//  When you create a Task object, you specify the code that should be executed asynchronously
//  This code can be a lambda expression, a method call, or any other piece of code that can be executed asynchronously.


// Thread Pool - A collection of background threads that are managed by the .NET runtime.
//  When you create a new task, it is scheduled to run on the thread pool


// Single Task
Task myTask = new Task(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Running after 2000ms");
});
myTask.Start();

//Single task with return type
Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(5000);
    Console.WriteLine("We can now get the number...");
    return 6;
});


Stopwatch sw = new Stopwatch();

sw.Start();

valueTask.Start();
int result = await valueTask;

sw.Stop();

Console.WriteLine($"Result: {result} | Finished in: {sw.ElapsedMilliseconds}ms");


//  Bad Practices - Blocking the execution thread!

//  Bad 
Console.WriteLine(valueTask.GetAwaiter().GetResult());

//  Bad
Console.WriteLine(valueTask.Result);

//  Bad
valueTask.Wait();


//  Task.Run method starts each task on a new thread from the thread pool.
//  However, the loop that creates the tasks is not waiting for them to complete before moving on to the next iteration.
//  As a result, by the time the tasks actually execute, the value of i has already been incremented to 21

//  To fix this, you need to capture the value of i in a local variable inside
//  the loop and use that variable inside the lambda expression passed to Task.Run.
for (int i = 0; i <= 20; i++)
{
    var temp = i;

    // Fire and forget - Not awaiting some task (you do not need the result)
    Task.Run(() => // if you add await here, this will run synchronously
    {
        Thread.Sleep(5000);
        Console.WriteLine($"[Finished] Task No. {temp}");
    });

    Console.WriteLine($"Index: {i}");
}


List<Task> tasks = new List<Task>();
for (int i = 0; i <= 10; i++)
{
    var temp = i;
    tasks.Add(Task.Run(() =>
    {
        Thread.Sleep(5000);
        Console.WriteLine($"[Finished] Task No. {temp}");
    }));
}

tasks.Add(Task.Run(() =>
{
    Thread.Sleep(8000);
    Console.WriteLine($"[Finished] The Longest Task..");
}));


Stopwatch stopWatch = new Stopwatch();

stopWatch.Start();

await Task.WhenAll(tasks);

stopWatch.Stop();

Console.WriteLine(stopWatch.ElapsedMilliseconds + "ms");

Console.ReadKey();