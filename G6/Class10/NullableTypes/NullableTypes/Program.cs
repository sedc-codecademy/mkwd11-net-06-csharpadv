using NullableTypes;

Person person = new Person();
Console.WriteLine(person.Id); //0 by default
Console.WriteLine(person.Score); //null by default

if(person.Score == null)
{
    Console.WriteLine("Score is null");
}

if (person.Score.HasValue) //same as if(person.Score != null)
{
    Console.WriteLine(person.Score);
}

person.Score = 100;

//int score = person.Score; //ERROR -> you can't assign nullable value (the range of Score has all whole numbers but also null)
//score variable has as range of values only whole numbers

if (person.Score.HasValue) //same as if(person.Score != null)
{
    int score = person.Score.Value;
}
int? secondScore = person.Score; //this is OK

person.IsEmployed = null; //we can do this because IsEmployeed is nullable boolean
person.IsEmployed = true;

Console.WriteLine(person.Name); //null by default
if (person.Name == null)
{
    Console.WriteLine("Name is null");
}

person.Name = "John";
person.Name = null;

if(person.Numbers == null)
{
    Console.WriteLine("List has null value");
}


//int?, bool? char? double? -> nullable types

//operator which checks for null

Person secondPerson = new Person();
secondPerson = null; //Every object is nullable


//?. is an operator that checks for null values. If the left side of the operator has value null, it returns null
//as result instead of throwing NullReference Exception. If the left side is not null, it will access the property/method.
string name = secondPerson?.Name;


Person thirdPerson = new Person();
thirdPerson = null;

string thirdPersonName = thirdPerson.Name;
