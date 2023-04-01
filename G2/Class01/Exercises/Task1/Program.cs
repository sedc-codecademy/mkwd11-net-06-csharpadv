List<string> names = new List<string>();

while (true)
{
    Console.WriteLine("Please enter a name or enter x to continue.");
    string name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("You did not enter anything. Please enter a name!\nPress enter to continue.");
        Console.ReadKey();
        continue;
    }

    if (name.ToLower() == "x")
    {
        break;
    }

    if (names.Contains(name))
    {
        Console.WriteLine("You entered an already existing name!\nPress enter to continue.");
        Console.ReadKey();
        continue;
    }

    names.Add(name);
}

string text = string.Empty;

while (true)
{
    Console.WriteLine("Now enter a text: ");

    text = Console.ReadLine();

    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("You did not enter anything. Please enter a text!\nPress enter to continue.");
        Console.ReadKey();
        continue;
    }

    break;
}

foreach (string name in names)
{
    List<string> splittedText = text.Split(" ").ToList();

    int nameCount = splittedText.Count(x => string.Equals(x, name, StringComparison.InvariantCultureIgnoreCase));

    Console.WriteLine($"{name}: {nameCount}");
}