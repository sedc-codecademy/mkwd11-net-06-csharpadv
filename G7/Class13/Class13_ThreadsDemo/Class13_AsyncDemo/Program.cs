namespace Class13_AsyncDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Send message is sync function, and the code will not proceed with execution of ShowAd, until send message is completed
            //SendMessage("Hello G7");
            //ShowAd();

            //We have invoked SendMessageAsync in async way, it will start its execution, but will not block the execution of the Main thread. ShowAd will be executed imediatly after
            //SendMessageAsync("Hello G7");
            //ShowAd();

            //await for the SendMessageAsync execution to be completed
            //Main needs to be marked as async and returns back Task, so it can use the await keyword for waiting of Async function to be completed
            await SendMessageAsync("Hello G7");
            ShowAd();

            Console.ReadLine();
        }

        static void SendMessage(string message)
        {
            Console.WriteLine("Sending message....");
            Thread.Sleep(10000); //simulation of sending a message (process that takes 10s)
            Console.WriteLine($"Message {message} processed");
            Console.WriteLine("Message was send successfully");
        }

        static void ShowAd()
        {
            Console.WriteLine("Here is an ad while you are waiting");
        }

        //SendMessageAsync
        //await SendMessageAsync
        static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message....");

            await Task.Run(() =>
            {
                Thread.Sleep(10000); //simulation of sending a message (process that takes 10s)
                Console.WriteLine($"Message {message} processed");
            });

            Console.WriteLine("Message was send successfully");
        }
    }
}