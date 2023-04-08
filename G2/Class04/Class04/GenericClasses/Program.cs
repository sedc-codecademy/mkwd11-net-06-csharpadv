using GenericClasses.Database;
using GenericClasses.Entities;

Dog sharko = new Dog()
{
    Id = 1,
    IsSheperd = true,
    Name = "Sharko"
};

Dog doncho = new Dog()
{
    Id = 2,
    IsSheperd = false,
    Name = "Doncho"
};

Cat zhika = new Cat()
{
    Id = 3,
    IsNice = true,
    Name = "Zhika"
};

Cat karolina = new Cat()
{
    Id = 4,
    IsNice = false,
    Name = "Karolina"
};

GenericDb<Dog>.Insert(sharko);
GenericDb<Dog>.Insert(doncho);

GenericDb<Cat>.Insert(zhika);
GenericDb<Cat>.Insert(karolina);

Console.WriteLine("\n");
GenericDb<Dog>.PrintAll();
Console.WriteLine("\n");
GenericDb<Cat>.PrintAll();