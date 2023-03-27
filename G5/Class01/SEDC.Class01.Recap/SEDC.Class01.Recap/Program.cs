using SEDC.Class01.Domain.Models;

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