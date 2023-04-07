

using SEDC.Class04.ExtensionMethods.Entities;

string text = "Hello there I am learning extension methods";

Console.WriteLine(text.DeleteLastLetter());
Console.WriteLine(text.GetStringFromPosition(5));

Console.WriteLine(text.AddQuatations());


List<string> names = new List<string>() { "Martin", "Antonio", "Aleksandar", "Monika" };
names.PrintElements();


List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
nums.PrintElements();