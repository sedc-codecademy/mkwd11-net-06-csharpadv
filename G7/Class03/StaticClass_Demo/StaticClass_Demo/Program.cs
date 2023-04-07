using Models;
using Models.Helpers;

namespace StaticClass_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(OrdersDb.GetAllUsers());

                    Console.WriteLine("Please select user by typing its ID");

                    int userSelection = InputHelper.InputInteger();

                    User selectedUser = OrdersDb.GetUser(userSelection);

                    Console.WriteLine("Please select one of the options:");
                    Console.WriteLine("1. Create new order");
                    Console.WriteLine("2. List my orders");

                    int optionSelected = InputHelper.InputInteger();

                    if (optionSelected != 1 && optionSelected != 2)
                    {
                        throw new Exception("You have selected wrong option");
                    }

                    if (optionSelected == 1)
                    {
                        Console.WriteLine("Insert order title");
                        string title = Console.ReadLine();

                        Console.WriteLine("Insert order description");
                        string description = Console.ReadLine();

                        Order newOrder = new Order(title, description);
                        OrdersDb.InsertOrder(selectedUser.Id, newOrder);
                        Console.WriteLine("Successfully created order");
                    }
                    else if (optionSelected == 2)
                    {
                        Console.WriteLine(selectedUser.GetOrdersInfo());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}