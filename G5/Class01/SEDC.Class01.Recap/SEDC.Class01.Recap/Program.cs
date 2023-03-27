using SEDC.Class01.Domain.Models;

#region Inheritance 

Dog dog = new Dog("Max");

dog.Bark();

dog.PrintInfo();

dog.MyFavouriteFood("Beef");

Cat cat = new Cat("Garfield", "orange");
cat.PrintInfo();
cat.Meow();

Animal randomAnimal = new Animal("Unknown");

// We cannot access these proeprties and methods because they are specific for Dog and Cat
//randomAnimal.Meow()
//randomAnimal.Bark();
//randomAnimal.color

#endregion

#region Collections

// List
List<int> listOfNumbers = new List<int>();

//Add One Element
listOfNumbers.Add(1);
listOfNumbers.Add(2);

//Remove One Element
listOfNumbers.Remove(1);


List<int> smallerListOfNumbers = new List<int>() { 5, 6, 7 };

listOfNumbers.AddRange(smallerListOfNumbers);
listOfNumbers.ForEach(x => Console.WriteLine(x));
Console.WriteLine();
listOfNumbers.RemoveRange(0, 2);
listOfNumbers.ForEach(x => Console.WriteLine(x));


//Dictionary(Key / Value Pairs)
Dictionary<string, long> phoneBook = new Dictionary<string, long>()
{
    { "John", 123123123 },
    { "Anna", 432432432 }
};

Console.WriteLine(phoneBook["John"]);
Console.WriteLine(phoneBook["Anna"]);

Console.WriteLine();

// Iterating only through phonebooks keys ( names of peoples )
foreach (string key in phoneBook.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();

// Iterating only through phonebooks values ( phone numbers of peoples )

foreach (long value in phoneBook.Values)
{
    Console.WriteLine(value);
}


#endregion

#region Exception Handling
// We are wrapping the code in try / catch blocks to handle if error is thrown
try
{
    List<Dog> dogs = new List<Dog>()
    {
        new Dog("Max"),
        new Dog("Rex"),
        new Dog("Snoopy")
    };

    // If FirstOrDefault returns null we will call null.PrintInfo() -> This wil result in NullReferenceException
    Dog rex = dogs.FirstOrDefault(x => x.Name == "Rex");
    rex.PrintInfo();
}
catch (NullReferenceException)
{
    // We will handle NullReferenceException in the specific catch
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[ERROR] You just handled a null reference exception");
    Console.ResetColor();
}
catch (Exception ex)
{
    // The rest of the exceptions are going to be handled inside the general Exception catch
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[ERROR] {ex.Message}");
    Console.ResetColor();
}
finally
{
    Console.WriteLine("Code Finished Executing!");
}


#endregion