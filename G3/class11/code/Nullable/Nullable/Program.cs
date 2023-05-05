using Nullable;

Person person = new Person();

Console.WriteLine(person.Id); //default 0
Console.WriteLine(person.Score); // null

person.Score = null;
person.HasPet = null;
//person.IsEmployed = null;

var case1 = person.Name = null;
var case2 = person.Username = null;

Console.ReadLine();
