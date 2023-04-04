using Polymorphism;
using Polymorphism.Domain.Models;

PetService petService = new PetService();
Cat cat = new Cat();
cat.Name = "Jilly";
cat.Age = 2;

Dog dog = new Dog();
dog.Name = "Sparky";
dog.Color = "Brown";

//all methods have the same name, but different signature, dependent on the params that we use when we call the method
//the appropriate implementation will be called

petService.PetStatus();
//PetStatus(string name, Cat cat)
petService.PetStatus("Kate", cat);
petService.PetStatus(cat);


//Runtime polymorphism
//the variable has the same type as the assigned object
Pet firstPet = new Pet();

Pet secondPet = new Cat();
secondPet.Name = "Billy";
//secondPet.Age -> Error, because secondPet is of type Pet
Console.WriteLine(secondPet.Name);
secondPet.Eat();

List<Pet> pets = new List<Pet>();
pets.Add(cat);
pets.Add(dog);
pets.Add(new Pet() { Name = "Barnie" });

foreach(Pet pet in pets)
{
    pet.Eat();
}