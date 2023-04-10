using StaticClasses;
using StaticClasses.Models;

Dog dog1 = new Dog() { Id = 1, Name = "Rex", Color = "Brown" };
Dog dog2 = new Dog() { Id = 2, Name = "Sparky", Color = "Black" };
Dog dog3 = new Dog() { Id = 3, Name = "Belka", Color = "White" };
Dog dog4 = new Dog() { Id = -1, Name = "Wa", Color = "" };

DogShelter.Dogs.Add(dog1);
DogShelter.Dogs.Add(dog2);
DogShelter.Dogs.Add(dog3);
DogShelter.Dogs.Add(dog4);

DogShelter.PrintAll();

Console.ReadLine();

