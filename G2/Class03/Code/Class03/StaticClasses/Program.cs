using StaticClasses.Entities;

User currentUser;

while (true)
{
    Console.Clear();

    Console.WriteLine("Welcome to the ordering menu");

    if (TextHelper.MessagesGenerated != 0)
    {
        Console.WriteLine($"People checked their order status {TextHelper.MessagesGenerated} times");
    }

    Console.WriteLine("Choose an User:");

    OrdersTempDB.ListUsers();
    int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());

    if (userChoice == -1)
    {
        continue;
    }
    currentUser = OrdersTempDB.Users[userChoice - 1];

    Console.Clear();
    Console.WriteLine("Orders menu");
    Console.WriteLine("1) Check orders");
    Console.WriteLine("2) Add new order");

    int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
    if (menuChoice == -1) continue;

    if (menuChoice == 1)
    {
        Console.Clear();
        Console.WriteLine("Choose one to check the status:");
        currentUser.PrintOrders();
        int orderChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
        if (orderChoice == -1) continue;
        TextHelper.GenerateStatusMessages(currentUser.Orders[orderChoice - 1].OrderStatus);
        Console.ReadLine();
    }
    else if (menuChoice == 2)
    {
        Console.Clear();
        Order newOrder = new Order();
        Console.WriteLine("Enter order name: ");
        newOrder.Title = Console.ReadLine();
        Console.WriteLine("Enter description:");
        newOrder.Description = Console.ReadLine();
        OrdersTempDB.InsertOrder(currentUser.Id, newOrder);
        Console.ReadLine();
    }
}