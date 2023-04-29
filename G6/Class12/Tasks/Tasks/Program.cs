//this code belongs to the initial thread
Console.WriteLine("Hello");

//creating a task, no result
Task firstTask = new Task(() =>
{
    Console.WriteLine("Hello from first task");
});

//give this task to a free thread
firstTask.Start();

//task that return a value
Task<int> taskWithReturnValue = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Returning a value...");
    return 10;
});
taskWithReturnValue.Start();


Task.Run(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Code that executes immediatelly");
});

//this waits for result (blocks the curent code)
Console.WriteLine(taskWithReturnValue.Result);

//We can't guarantee the order here
for (int i = 0; i < 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine(temp);
    });
}

Console.ReadLine();
