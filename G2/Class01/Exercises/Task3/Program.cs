using Task3.Enums;

int draws = 0;
int userWins = 0;
int computerWins = 0;

static int UserPick()
{
    while (true)
    {
        Console.WriteLine("Please pick one:\n1.) Rock 2.) Paper 3.) Scissors");
        string userOption = Console.ReadLine();

        if (string.IsNullOrEmpty(userOption))
        {
            Console.WriteLine("Please try again, invalid input!\nPress enter to continue.");
            Console.ReadKey();
            continue;
        }

        bool userInputValidation = int.TryParse(userOption, out int userMove);

        if (!userInputValidation)
        {
            Console.WriteLine("Please try again, invalid input!\nPress enter to continue.");
            Console.ReadKey();
            continue;
        }

        if (userMove > 3 || userMove <= 0)
        {
            Console.WriteLine("Please try again, invalid input!\nPress enter to continue.");
            Console.ReadKey();
            continue;
        }

        return userMove;
    }
}

static OptionEnum ComputerPick()
{
    Random rnd = new Random();
    int randomNumber = rnd.Next(1, 4);

    return (OptionEnum)randomNumber;
}

static ResultEnum DecideWinner(OptionEnum userSelection, OptionEnum computerSelection)
{
    if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Scissors || userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Rock || userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Paper)
    {
        return ResultEnum.PlayerWins;
    }

    if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Paper || userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Scissors || userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Rock)
    {
        return ResultEnum.ComputerWins;
    }

    return ResultEnum.Draw;
}

static decimal CalculatePercentage(int wins, int total)
{
    return (wins / (decimal)total);
}

while (true)
{
    Console.Clear();
    OptionEnum userSelection = (OptionEnum)UserPick();
    OptionEnum computerSelection = ComputerPick();

    ResultEnum result = DecideWinner(userSelection, computerSelection);

    switch (result)
    {
        case ResultEnum.PlayerWins:
            userWins++;
            break;
        case ResultEnum.ComputerWins:
            computerWins++;
            break;
        case ResultEnum.Draw:
            draws++;
            break;
        default:
            throw new Exception("Invalid outcome");
    }

    int playedGames = userWins + computerWins + draws;

    Console.WriteLine($"{"User",10}|{userWins,6}|{$"{CalculatePercentage(userWins, playedGames):P}",6}");
    Console.WriteLine($"{"Computer",10}|{computerWins,6}|{$"{CalculatePercentage(computerWins, playedGames):P}",6}");
    Console.WriteLine($"{"Draws",10}|{draws,6}|{$"{CalculatePercentage(draws, playedGames):P}",6}");

    Console.WriteLine("Wanna play again?\nType Yes/No");

    if (Console.ReadLine().ToLower() == "no")
    {
        break;
    }
}