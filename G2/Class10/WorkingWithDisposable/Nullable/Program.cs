using Nullable;

Person person = new Person();
Console.WriteLine(person.Id); //is 0 by default
Console.WriteLine(person.Score); // is null by default

Console.WriteLine(person.Wife); // because Wife is a class, it is nullable

person.HasPet = null;
//person.Id = null; this can not be !

person = null;