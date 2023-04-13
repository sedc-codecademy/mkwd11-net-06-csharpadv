using Recap;

string text = "Hello from Slave.";

StaticHelper.PrintTextWithColor(text, ConsoleColor.Magenta);

text.PrintTextWithExtensionMethod();

text.PrintTextWithExtensionMethodAndParameter(ConsoleColor.Green);

text.ToString();
