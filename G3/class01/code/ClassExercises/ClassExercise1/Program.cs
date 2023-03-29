List<string> words = new List<string>();

while(true)
{
    Console.WriteLine("Please enter a word or press X to exit:");
    string wordInput = Console.ReadLine();

    if (wordInput.ToLower() != "x")
    {
        words.Add(wordInput);
    }

    if (wordInput.ToLower() == "x") 
    {
        break;
    }
}

Console.WriteLine("Please enter a text:");
string textInput = Console.ReadLine();

List<string> splittedText = textInput.Split(" ").ToList();

foreach (string word in words) 
{
    int count = splittedText.Count(word => string.Equals(word, word));

    //int count = splittedText.Count((word) => 
    //{
    //    return string.Equals(word, word);
    //});

    Console.WriteLine($"{word} : {count}");
}