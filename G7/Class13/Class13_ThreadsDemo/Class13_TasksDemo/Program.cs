namespace Class13_TasksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Task taskThatDoesNotReturnResult = new Task(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Executing task 1");
            });

            //Task start starts the task in async wait, the main program will proceed with the execution. It the task takes more time to be executed than the rest of the main code, the Console.Writeline of the task will not be presented because the main app has fininshed in meanwhile
            taskThatDoesNotReturnResult.Start();
            //RunSynchronously is a method that runs the task synchronious way.
            //task1.RunSynchronously();
            Console.WriteLine($"Task1 is completed: {taskThatDoesNotReturnResult.IsCompleted}");

            Task<int> taskThatReturnsResult = new Task<int>(() =>
            {
                Console.WriteLine("Execution of task 2");
                return 10;
            });
            taskThatReturnsResult.Start();
            int a = taskThatReturnsResult.Result;

            Console.WriteLine($"Result is {a}");

            Task<int> taskThatReturnsResultAndAcceptsArguments = new Task<int>((arguments) =>
            {
                object[] parametars = (object[])arguments;
                Console.WriteLine($"Value of a = {parametars[0]} & b = {parametars[1]}");
                return (int)parametars[0] + (int)parametars[1];
            }, new object[] { 2, 3 });
            taskThatReturnsResultAndAcceptsArguments.Start();
            int result = taskThatReturnsResultAndAcceptsArguments.Result;

            //We can't guarantee the order
            for(int i = 0; i < 20; i++)
            {
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(temp);
                });
            }

            Console.WriteLine("End of the app");
            
            Console.ReadLine();
        }
    }
}