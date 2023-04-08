1. Create an abstract class Car with properties string Brand, FuelTypeEnum FuelType, string Model, DateTime YearOfProduction, int HorsePower.
2. Create an Interface, ICar that has a method Drive(string destinationName) and a method Radio(string songName).
3. Create 2 classes, one FrenchCar and one GermanCar. The French has a property bool Navigation, the German has a property int MaxSpeed.
4. Car inherits from ICar. The FrenchCar and GermanCar inherit from Car.
5. Create a static method PrintMaxSpeed in the GermanCar class, also create a static method PrintNavigation in the FrenchCar class.