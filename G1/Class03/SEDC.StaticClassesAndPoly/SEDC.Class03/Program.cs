using SEDC.Class03.Entities;
using SEDC.Class03.Utils;


#region Static classes basics
//Console.WriteLine("Hello World!");
//Console.WriteLine(Math.PI);


//Console.WriteLine(FirstStaticClass.Counter);

//Console.WriteLine(FirstStaticClass.AddTwoNumbers(100, 239));

//FirstStaticClass.Counter++;
//Console.WriteLine(FirstStaticClass.Counter);

//FirstStaticClass.WriteLine(FirstStaticClass.Counter.ToString());
#endregion

#region Static classes for util methods
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("today we are learning static classes."));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("Today is Monday"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("1234567890"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter("d"));
//Console.WriteLine(StringUtils.CapitaliseFirstLetter(null));

//Console.WriteLine("Please enter a number");
//int number = StringUtils.VerifyStringNumber(Console.ReadLine());

//if (number != -1)
//    Console.WriteLine($"The number is: {number}");
#endregion

#region Static members in non static classes

User user1 = new User(12345, "Martin", "Panovski");
user1.PrintInfo();
User.UserCount++;

User user2 = new User(12332, "Stojadin", "Stojkovski");
user2.PrintInfo();
User.UserCount++;

User.PrintUserCount();


#endregion



#region Boxing and Unboxxing

// Boxing an integer in to a more universal type, object
// All value types derive from object
// That is why we can box any value type in to object

int number1 = 9000;
object obj1 = number1;
Console.WriteLine(obj1); // works

// Unboxing an object back in to integer
// Since an object variable can hold any value we can try and unbox it to a specific type
object obj2 = 90000;
int number2 = (int)obj2; // -> This change of type is called casting
Console.WriteLine(number2); // works
Console.ReadLine();

object numInString = "10";
int numberFromString = (int)numInString;


object user = new User(1, "Test", "Test");
User u = (User)user;

#endregion
