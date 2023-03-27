List<string> names = new List<string>();

while(true)
{
    Console.WriteLine("Please enter a name, and press x to exit.");
    string input = Console.ReadLine();

    if (input.ToLower() != "x")
    {
        names.Add(input);
    }

    if (input.ToLower() == "x") 
    {
        break;
    }
}

string inputText = "";
Console.WriteLine("Please enter a text:");

string textInput = Console.ReadLine();
List<string> splittedText = textInput.Split(" ").ToList();

foreach (string name in names) 
{
    int count = splittedText.Count((word) => string.Equals(word, name));
    Console.WriteLine($"{name} : {count}");
}





