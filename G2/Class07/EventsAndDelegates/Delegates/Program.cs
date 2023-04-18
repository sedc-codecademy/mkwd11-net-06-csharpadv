void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

StringDelegate stringDelegateToUpper = ToUpperCase;
StringDelegate stringDelegateToLower = ToLowerCase;

stringDelegateToUpper("Some lowercase text => [transform to uppercase]");
stringDelegateToLower("THIS IS SOME UPPERCASE TEXT => [TRANSFORM TO LOWERCASE]");

public delegate void StringDelegate(string text);