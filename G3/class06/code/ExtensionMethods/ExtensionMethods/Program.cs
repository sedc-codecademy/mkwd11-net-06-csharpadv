using ExtensionMethods.Helpers;

string text = "C# Advanced is an awesome subject with great demos and activities!";

string shortText = text.Shorten(3).QuoteString();

Console.WriteLine(shortText);

List<string> strings = new List<string>() { "str1", "str2", "str3" };
List<int> ints = new List<int>() { 5, 22, -18 };
List<bool> bools = new List<bool> { true, false, true };

strings.GoTrough();
ints.GoTrough();
bools.GoTrough();