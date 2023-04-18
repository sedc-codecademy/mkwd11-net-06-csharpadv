using StaticClassRecap;

Console.WriteLine(StaticClass.Text);
StaticClass.Text = "We are learning about static classes.";
Console.WriteLine(StaticClass.Text);

string someText = "make this text uppercase";
someText.ToUpperCase();