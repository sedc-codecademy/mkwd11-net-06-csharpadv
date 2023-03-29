
using RockPaperScissors.Enum;

int userWins = 0;
int computerWins = 0;
int draw = 0;


OptionEnum userSelection = SelectOption();
OptionEnum computerSelection = ComputerOption();

ResultEnum result = DecideWinner(userSelection, computerSelection);

Console.ReadLine();

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
