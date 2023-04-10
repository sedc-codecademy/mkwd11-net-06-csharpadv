using Polymorphism;
using Polymorphism.Models;

var dog = new Dog()
{
    Name = "Majlo",
    IsGoodBoy = true
};

dog.Eat();



var cat = new Cat()
{
    Name = "Garfiled",
    IsLazy = true
};

cat.Eat();


var petService = new PetService();

petService.PetStatus(dog, "Viktor");
petService.PetStatus("Viktor", dog);
petService.PetStatus(cat, "Dragan");
petService.PetStatus(cat);

petService.PetStatus()