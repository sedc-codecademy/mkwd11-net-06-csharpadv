List<string> words = new List<string>();
string input = string.Empty; //""

do
{
    Console.WriteLine("Enter a word");
    string word = Console.ReadLine();

    words.Add(word);

    Console.WriteLine("Enter x if you don't want to continue");
    input = Console.ReadLine();
}
//while (input.ToLower() != "x");
while (input.Equals("x", StringComparison.InvariantCultureIgnoreCase) == false);

Console.WriteLine("Enter text:");
string text = Console.ReadLine();

List<string> textWords = text.Split(" ").ToList();

foreach(string word in words)
{
    //int count = textWords.Count(x => x.Equals(word, StringComparison.InvariantCultureIgnoreCase));
    //int count = textWords.Count(x => x.ToLower() == word.ToLower());

    //List<string> matchedWords = textWords.Where(x => x.ToLower() == word.ToLower()).ToList();
    List<string> matchedWords = textWords.Where(x => x.ToLower().Contains(word.ToLower())).ToList();
    int count = matchedWords.Count();

    Console.WriteLine($"{word} : {count}");
}