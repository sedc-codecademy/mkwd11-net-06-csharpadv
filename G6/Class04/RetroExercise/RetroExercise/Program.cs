using RetroExercise;

Dog dog = new Dog();
dog.Name = "";
dog.Color = "Brown";
dog.Id = 1;


//dog.Validate(dog) -> static method, can not be accessed via an instance (object), but through the name of the class
if (Dog.Validate(dog))
{
    DogShelter.Dogs.Add(dog);
}

Dog anotherDog = new Dog();
anotherDog.Name = "Barnie";
anotherDog.Color = "Brown";
anotherDog.Id = 3;
if (Dog.Validate(anotherDog))
{
    DogShelter.Dogs.Add(anotherDog);
}

DogShelter.PrintAll();
