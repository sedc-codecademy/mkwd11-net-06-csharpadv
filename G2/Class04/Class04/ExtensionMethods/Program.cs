using ExtensionMethods.Helpers;

List<string> words = new List<string>()
{
    "Hello","Bye","BMW","SEDC","Bojan","Kepabi"
};

words.Print();
Console.WriteLine("\n");

List<int> numbers = new List<int>()
{
    1,3,5,7,9,11,13,14,15,16,17,18,19,20,21,22,23
};

numbers.Print();
Console.WriteLine("\n");
words.GetInfo();
Console.WriteLine("\n");
numbers.GetInfo();
Console.WriteLine("\n");
string hello = "hello";
Console.WriteLine(hello.CapitalizeFirstLetter("Marko"));
Console.WriteLine("\n");
string text1 = "Today is Saturday and the weather is nice.";
text1.ColorText(ConsoleColor.Green);
text1.ColorText(ConsoleColor.Red);
text1.ColorText(ConsoleColor.Yellow);

//same thing as above
ListHelper.ColorText(text1 , ConsoleColor.Cyan);