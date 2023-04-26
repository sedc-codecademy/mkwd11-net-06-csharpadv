using SEDC.Class10.Nullable.Domain;

Person person = new Person();

//person = null; // null

Console.WriteLine(person.Id); //0 by default
Console.WriteLine(person.Score); //null by default

Console.WriteLine(person.Name); //null by default
person.Name = null;

Console.WriteLine(person.IsStudent); // false by default
Console.WriteLine(person.IsEmployed); //null by default

//person.IsStudent = null;

person.IsEmployed = null;


//Nullabale method
person.isTrue(null);
person.isFalse();
person.Number();
person.Text();

Person personTwo = new Person();

personTwo = null; //null