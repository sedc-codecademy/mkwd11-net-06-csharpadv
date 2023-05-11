namespace Class15_AsyncDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Arena Sport");
            StartCommercial();
            Game();

            Console.ReadLine();
        }

        static void Game()
        {
            Console.WriteLine("Game between Real Madrid vs Man City started.....");
            Thread.Sleep(5000);
            Console.WriteLine("Haland shoots on goal, but misses....");
            Thread.Sleep(3000);
            Console.WriteLine("Carvajal recevies yellow card....");
            Thread.Sleep(7000);
            Console.WriteLine("GOOOOOL - Vinicius scores ...");
            Console.WriteLine("It is 1 - 0 for Real Madrid");
        }

        //static async Task Game()
        //{
        //    await Task.Run(() =>
        //    {
        //        Console.WriteLine("Game between Real Madrid vs Man City started.....");
        //        Thread.Sleep(5000);
        //        Console.WriteLine("Haland shoots on goal, but misses....");
        //        Thread.Sleep(3000);
        //        Console.WriteLine("Carvajal recevies yellow card....");
        //        Thread.Sleep(7000);
        //        Console.WriteLine("GOOOOOL - Vinicius scores ...");
        //        Console.WriteLine("It is 1 - 0 for Real Madrid");
        //    });
        //}

        static async Task StartCommercial()
        {
            await Task.Run(() =>
            {
                List<string> ads = new List<string>
                                    {
                                        "Coca cola commercial",
                                        "Heineken commercial",
                                        "Chipsy commercial"
                                    };

                while (true)
                {
                    Thread.Sleep(6000);
                    Random rnd = new Random();
                    var randomNumber = rnd.Next(0, ads.Count);
                    Console.WriteLine(ads[randomNumber]);
                }
            });
        }
    }
}