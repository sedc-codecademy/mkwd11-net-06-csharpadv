using GameApp.Domain.Enums;

int userWins = 0;
int computerWins = 0;
int draws = 0;

while ((userWins + computerWins + draws) <= 3)
{
    try
    {
        GameOption userOption = SelectUserOption();
        GameOption computerOption = SelectComputerOption();
        Console.WriteLine(computerOption);

        Result result = SeeWhoWins(userOption, computerOption);

        switch (result)
        {
            case Result.UserWins:
                userWins++;
                break;
            case Result.ComputerWins:
                computerWins++;
                break;
            case Result.Draw:
                draws++;
                break;
            default:
                throw new Exception("This shouldn't happen");
                break;
        }

        Console.WriteLine($"user wins: {userWins}");
        Console.WriteLine($"computer wins: {computerWins}");
        Console.WriteLine($"draws: {draws}");

    }
    catch (Exception e)
    {
        Console.WriteLine("An error occurred");
        Console.WriteLine(e.Message);
        Console.WriteLine("Try again");
    }
}

GameOption SelectUserOption()
{
    Console.WriteLine("Select an option");
    Console.WriteLine($"{(int)GameOption.Rock}) {GameOption.Rock}");
    Console.WriteLine($"{(int)GameOption.Paper}) {GameOption.Paper}");
    Console.WriteLine($"{(int)GameOption.Scissors}) {GameOption.Scissors}");

    string input = Console.ReadLine();
    bool success = int.TryParse(input, out int number);

    if (!success)
    {
        throw new Exception("Input could not be parsed into a number");
    }

    if (number < 1 || number > 3)
    {
        throw new Exception("Invalid option");
    }

    return (GameOption)number;
}

GameOption SelectComputerOption()
{
    int randomNumber = new Random().Next(1, 4);
    return (GameOption)randomNumber;
}

Result SeeWhoWins(GameOption userOption, GameOption computerOption)
{
    if (userOption == GameOption.Rock && computerOption == GameOption.Scissors ||
        userOption == GameOption.Paper && computerOption == GameOption.Rock ||
        userOption == GameOption.Scissors && computerOption == GameOption.Paper)
    {
        return Result.UserWins;
    }
    else if (userOption == computerOption)
    {
        return Result.Draw;
    }
    else
    {
        return Result.ComputerWins;
    }
}
