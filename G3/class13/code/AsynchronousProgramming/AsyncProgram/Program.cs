
using System.Collections.Concurrent;
using System.Diagnostics;

int Job(int time) 
{
    Thread.Sleep(time * 1000);
    Console.WriteLine($"Task {time} DONE");
    return time;
}

void ShowResult(int number1, int number2, int number3) 
{
    Console.WriteLine("Show result executed!");
    Console.WriteLine($"The final result is {number1 + number2 + number3}");
}

void StartAllJobs() 
{
    var result1 = Job(12);
    var result2 = Job(13);
    var result3 = Job(14);

    ShowResult(result1, result2, result3);
}

async void StartAllJobsAsync() 
{
    var task1 = new Task<int>(() =>
    {
        Console.WriteLine("Task 1 started");
        return Job(3);
    });

    var task2 = new Task<int>(() =>
    {
        Console.WriteLine("Task 2 started");
        return Job(5);
    });

    var task3 = new Task<int>(() =>
    {
        Console.WriteLine("Task 3 started");
        return Job(7);
    });

    var task4 = new Task(() =>
    {
        while (true) 
        {
            Thread.Sleep(1000);
            Console.WriteLine("Show task statuses: ");
            Console.WriteLine($"-- {task1.Status}");
            Console.WriteLine($"-- {task2.Status}");
            Console.WriteLine($"-- {task3.Status}");
        }
    });

    task1.Start();
    task2.Start();
    task3.Start();
    task4.Start();

    Task.WaitAll(task1, task2, task3);

    ShowResult(task1.Result, task2.Result, task3.Result);
    //ShowResult(await task1, await task2, await task3);
}


Console.WriteLine("Please press enter to start: ");
Console.ReadLine();

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine("====start====");
//StartAllJobs();
StartAllJobsAsync();
Console.WriteLine("====stop====");

stopwatch.Stop();

var time = stopwatch.Elapsed;

var elapsedTime = string.Format("{0:00}:{1:00}:{2:00}",
    time.Minutes, time.Seconds, time.Milliseconds / 10);

Console.WriteLine($"RunTime: {elapsedTime}");
