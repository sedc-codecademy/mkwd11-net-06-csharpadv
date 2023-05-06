namespace Class13_ThreadsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintMessagesSync();
            //NotificationWorker();

            PrintMessagesDifferentThreads();
        }

        static void PrintMessagesSync()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to SEDC");
            Thread.Sleep(5000);
            Console.WriteLine("Programming academy");
            Console.WriteLine("G7");
            Console.WriteLine("Thank you");
        }

        static void NotificationWorker()
        {
            while (true)
            {
                Console.WriteLine("Check for new emails in database...");
                Console.WriteLine("Sending emails....");

                Thread.Sleep(10000);
            }
        }

        static void PrintMessagesDifferentThreads()
        {
            Console.WriteLine("Hello from Main Thread");

            Thread firstThread = new Thread(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Hello from Thread 1");
            });

            firstThread.Start();

            Thread secondThread = new Thread(() =>
            {
                //Thread.Sleep(5000);
                Console.WriteLine("Hello from Thread 2");
            });

            secondThread.Start();
        }
    }
}