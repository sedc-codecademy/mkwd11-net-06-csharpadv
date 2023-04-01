namespace Class01_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userWins = 0;
            int computerWins = 0;
            int ties = 0;

            //1 - rock
            //2 - paper
            //3 - scissors
            while (true)
            {
                Console.WriteLine("[P]lay");
                Console.WriteLine("[S]tats");
                Console.WriteLine("[E]xit");
                string choiceInput = Console.ReadLine();

                bool closeTheApp = false;

                switch (choiceInput)
                {
                    case "P":
                    case "p":
                        {
                            Console.WriteLine("---------Play----------");
                            Console.WriteLine("Please choose your option:\n\t[1] Rock\n\t[2] Paper\n\t[3] Scissors");
                            string optionInput = Console.ReadLine();

                            if (!int.TryParse(optionInput, out int selectedOption))
                            {
                                Console.WriteLine("Wrong option selected");
                                break;
                            }

                            if (selectedOption < 1 || selectedOption > 3)
                            {
                                Console.WriteLine("Wrong option selected");
                                break;
                            }

                            Console.WriteLine($"User choice: {(OptionEnum) selectedOption}");

                            Random rnd = new Random();
                            int computerOption = rnd.Next(1, 4);
                            Console.WriteLine($"Computer choice: {(OptionEnum) computerOption}");

                            if(computerOption == selectedOption)
                            {
                                ties++;
                                Console.WriteLine("It is a tie");
                            }
                            else if(computerOption == (int) OptionEnum.Rock && selectedOption == (int)OptionEnum.Paper)
                            {
                                userWins++;
                                Console.WriteLine("User wins");
                            } else if(computerOption == (int)OptionEnum.Rock && selectedOption == (int)OptionEnum.Scissors)
                            {
                                computerWins++;
                                Console.WriteLine("Computer wins");
                            } else if (selectedOption == (int)OptionEnum.Rock && computerOption == (int)OptionEnum.Paper)
                            {
                                computerWins++;
                                Console.WriteLine("Computer wins");
                            } else if(selectedOption == (int)OptionEnum.Rock && computerOption == (int)OptionEnum.Scissors)
                            {
                                userWins++;
                                Console.WriteLine("User wins");
                            } else if(selectedOption == (int)OptionEnum.Paper && computerOption == (int)OptionEnum.Scissors)
                            {
                                computerWins++;
                                Console.WriteLine("Computer wins");
                            } else if(computerOption == (int)OptionEnum.Paper && selectedOption == (int)OptionEnum.Scissors)
                            {
                                userWins++;
                                Console.WriteLine("User wins");
                            }

                            break;
                        }
                    case "S":
                    case "s":
                        {
                            Console.WriteLine("---------Stats----------");
                            Console.WriteLine($"User wins: {userWins}\nComputer wins: {computerWins}\nTies: {ties}");

                            decimal winsPercent = userWins / (decimal)(userWins + computerWins + ties); //0.66666 => 66.67%
                            decimal lostsPercent = computerWins / (decimal)(userWins + computerWins + ties); //0.3333
                            decimal tiesPercent = ties / (decimal)(userWins + computerWins + ties);

                            Console.WriteLine($"Wins: {winsPercent.ToString("P")}\nLosts: {lostsPercent.ToString("P")}\nTies: {tiesPercent.ToString("P")}");
                            break;
                        }
                    case "E":
                    case "e":
                        {
                            Console.WriteLine("---------Exit----------");
                            closeTheApp = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not supported option, returning back to menu.");
                            break;
                        }
                }

                if (closeTheApp)
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
            }
        }
    }
}