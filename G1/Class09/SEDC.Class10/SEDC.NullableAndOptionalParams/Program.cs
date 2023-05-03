
using SEDC.NullableAndOptionalParams;

Person martin = new Person() { Id = 1, Name = "Martin" };
martin.Score = null;

if (martin.Score.HasValue)
{
    Console.WriteLine(martin.Score.Value);
}
else
{
    Console.WriteLine("Score for martin is null");
}

if(martin.Score != null)
{
    Console.WriteLine(martin.Score.Value);
}

if(martin.Score is not null)
{
    Console.WriteLine(martin.Score.Value);
}


// Optional params in C#. They always go at the end of the parameters in the method definition
void GreetPerson(string greet, string name = "", DateTime? dateTime = null, bool? IsDamjan = null)
{
    Console.WriteLine($"{greet} {name}");
}

GreetPerson("Hello", "students");
GreetPerson("Hello there!");

// If you have a lot of params in the method
// but you need to call the method with the first and the third param only
// then you add a target name for the wanted parameter
GreetPerson("Hello again!", dateTime: DateTime.Now);

