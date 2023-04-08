using Exercise.Entities;
using Exercise.Entities.Enums;

GermanCar bmw = new GermanCar()
{
    Brand = "BMW",
    FuelType = (FuelType)1,
    HorsePower = 200,
    MaxSpeed = 350,
    Model = "M5",
    YearOfProduction = new DateTime(2020, 5, 5)
};

FrenchCar citroen = new FrenchCar()
{
    Brand = "Citroen",
    FuelType = FuelType.Diesel,
    HorsePower = 100,
    Model = "Berlingo",
    YearOfProduction = new DateTime(1998, 5, 5),
    Navigation = true
};

bmw.Radio("some song");
citroen.Drive("Valandovo");

FrenchCar.PrintFrenchCar(citroen.Brand);
GermanCar.PrintGermanCar(bmw.MaxSpeed);