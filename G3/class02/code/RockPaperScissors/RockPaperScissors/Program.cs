using RockPaperScissors.Enum;

int userWins = 0;
int computerWins = 0;
int draws = 0;

while (true) 
{
    try
    {
        OptionEnum userSelection = SelectOption();
        OptionEnum computerSelection = ComputerOption();

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
                break;
        }

        int playedGames = userWins + computerWins + draws;

        Console.WriteLine($"===={userSelection}=====||====={computerSelection}====");
        Console.WriteLine($"========{result}========");

        Console.WriteLine($"{"Player",10}|{"Wins",6}|{"%",6}");

        Console.WriteLine($"{"User",10}|{userWins,6}|{$"{CalculatePercentage(userWins, playedGames):P}",6}");
        Console.WriteLine($"{"Computer",10}|{computerWins,6}|{$"{CalculatePercentage(computerWins, playedGames):P}",6}");
        Console.WriteLine($"{"Draw",10}|{draws,6}|{$"{CalculatePercentage(draws, playedGames):P}",6}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static OptionEnum SelectOption() 
{
    Console.WriteLine("Please select an option: ");
    Console.WriteLine($"{(int)OptionEnum.Rock}. {OptionEnum.Rock}");
    Console.WriteLine($"{(int)OptionEnum.Paper}. {OptionEnum.Paper}");
    Console.WriteLine($"{(int)OptionEnum.Scissors}. {OptionEnum.Scissors}");

    string input = Console.ReadLine();

    bool sucessParse = int.TryParse(input, out int option);

    if (!sucessParse) 
    {
        throw new Exception("Invalid input for select option");
    }

    if (option < 1 || option > 3) 
    {
        throw new Exception("Invalid input for select option");
    }

    return (OptionEnum)option;
}
static OptionEnum ComputerOption()
{
    Random rnd = new Random();
    int randomNumber = rnd.Next(1,4);

    return (OptionEnum)randomNumber;
}
static ResultEnum DecideWinner(OptionEnum userSelection, OptionEnum computerSelection)
{
    if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Scissors ||
        userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Rock ||
        userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Paper) 
    {
        return ResultEnum.PlayerWins;
    }

    //ternary expression
    return userSelection == computerSelection ? ResultEnum.Draw : ResultEnum.ComputerWins;

    //if (userSelection == computerSelection)
    //{
    //    return ResultEnum.Draw;
    //}
    //else 
    //{
    //    return ResultEnum.ComputerWins;
    //}
}
static decimal CalculatePercentage(int wins, int total)
{
    return (wins / (decimal)total);
}
