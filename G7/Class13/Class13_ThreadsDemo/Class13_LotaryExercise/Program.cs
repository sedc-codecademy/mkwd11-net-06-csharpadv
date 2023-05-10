namespace Class13_LotaryExercise
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<LotteryRound> rounds = new List<LotteryRound>();

            LotteryRound firstRound = new LotteryRound
            {
                RoundNo = 1,
                DrawTime = DateTime.Now.AddMinutes(30)
            };

            rounds.Add(firstRound);
            //1. creating a list of rounds
            //2. adding new round to the list of rounds
            //call AddCode
            //update the list of rounds with the state that has comed as a result of the AddCode function

            //function AddCode
            //that accepts current state of the rounds
            //finds out which round is active
            //adds code to that round
            //returns back updated state of the rounds
            //rounds = AddCode(rounds, "CCAS123");

            Console.WriteLine($"[{DateTime.Now}] Round 1 is opened, please send your codes");
            for (int i = 0; i < 5; i++)
            {
                string code = $"Round1+{i}";
                rounds = AddCode(rounds, code);
            }

            Draw(rounds); //async execution of the function
            //await Draw(rounds); //waiting for the function to execute before moving on the next line (same as synced execution)

            rounds.Add(new LotteryRound
            {
                RoundNo = rounds.Count + 1,
                DrawTime = DateTime.Now.AddMinutes(30)
            });

            Console.WriteLine($"[{DateTime.Now}] Round 2 is opened, please send your codes");
            for (int i = 0; i < 5; i++)
            {
                string code = $"Round2+{i}";
                rounds = AddCode(rounds, code);
            }

            Console.ReadLine();
        }

        static List<LotteryRound> AddCode(List<LotteryRound> rounds, string code)
        {
            //check the code if it is valid
            Thread.Sleep(2000);
            LotteryRound activeRound = rounds.OrderByDescending(x => x.RoundNo).First();
            activeRound.Codes.Add(code);
            Console.WriteLine($"[{DateTime.Now}] New code {code} is sent");
            return rounds;
        }

        static async Task Draw(List<LotteryRound> rounds)
        {
            await Task.Run(() =>
            {
                LotteryRound activeRound = rounds.OrderByDescending(x => x.RoundNo).First();
                Console.WriteLine($"[{DateTime.Now}] Drawing for the round {activeRound.RoundNo} has started...");
                Thread.Sleep(15000);
                Random rnd = new Random();
                //random number between 0 - 20, not including the 20
                int randomNumber = rnd.Next(0, activeRound.Codes.Count);
                Console.WriteLine($"[{DateTime.Now}] The winner of the round {activeRound.RoundNo} is the user with code {activeRound.Codes[randomNumber]}");
            });
        }
    }
}