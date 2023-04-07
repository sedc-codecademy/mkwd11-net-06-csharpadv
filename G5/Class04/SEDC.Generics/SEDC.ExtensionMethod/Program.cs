using SEDC.ExtensionMethod.Helpers;

string test = "Lorem ipsum .....";

Console.WriteLine(test.QuoteString(5));



Console.WriteLine("===== Generic extension method ==========");

List<string> list = new List<string>() { "string 1","string 2", "string 3"};

list.GenericHelpers();