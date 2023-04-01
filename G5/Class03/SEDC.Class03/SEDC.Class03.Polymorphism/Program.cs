using SEDC.Class03.Domain;
using SEDC.Class03.Domain.Models;
using SEDC.Class03.PartialClasses;

// OOP Pillars
// Polymorphism
// Abstraction
// Inheritance
// Encapsulation


// Poly -> Many
// Morp -> Form
// Polymorphism -> Many Forms

// Runtime Polymorphism
// Compiletime Polymorphism

// Application Runtime
// Types can differ in runtime

//while (true)
//{
//    Console.WriteLine("Application is running...");
//}

// Application Compiletime

#region Runtime Polymorphism (Method Overriding)
// This is called 'runtime' polymorphism because the type from which the method is going to be called is determined at runtime


Console.WriteLine("Runtime Polymorhism");
Console.WriteLine();

Dog sparky = new Dog() { Name = "Sparky", IsGoodBoi = true };
Cat garfield = new Cat() { Name = "Garfield", IsLazy = true };


List<Pet> pets = new List<Pet>() { sparky, garfield };

// The Eat() method is going to be called from the runtime type
pets.ForEach(pet => pet.Eat());

#endregion

Console.WriteLine();

#region Compiletime Polymorphism (Method Overloaring)
Console.WriteLine("Compiletime Polymorhism");
Console.WriteLine();

PetService service = new PetService();

service.PetStatus(sparky, "John");
service.PetStatus("Anna", sparky);
service.PetStatus(garfield, "Max");

Console.WriteLine();

service.PetStatus(sparky);
service.PetStatus(garfield);

Console.WriteLine();

sparky.Eat("snacks");

#endregion


Console.WriteLine();
Console.WriteLine();

#region Partial Classes

Human human = new Human() { Name = "Angel", Age = 21 };
human.Greet();

#endregion

#region Structs (Structures)

// Reference Type
// Value Type

Person person = new Person()
{
    Name = "Angel",
    Age = 21,
    Address = new Address()
    {
        Street = "Random Street",
        Number = 25
    }
};

Console.WriteLine("=== Reference Type ===");

Console.WriteLine("Before Processing");
Console.WriteLine(person.Name);

ProcessReferenceType(person);

Console.WriteLine("After Processing");
Console.WriteLine(person.Name);


Console.WriteLine("=== Value Type ===");
int num = 15;

Console.WriteLine("Before Processing");
Console.WriteLine(num);
Console.WriteLine(person.Address.Number);

ProcessValueType(num, person.Address);

Console.WriteLine("After Processing");
Console.WriteLine(num);
Console.WriteLine(person.Address.Number);
void ProcessReferenceType(Person person)
{
    person.Name = "Danilo";
}

void ProcessValueType(int number, Address address)
{
    address.Number = 100;
    number = 1500;
}

#endregion