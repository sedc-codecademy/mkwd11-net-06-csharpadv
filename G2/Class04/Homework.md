###Homework Generics
1. Crate a car dealership app. Make a BaseEntity abstract class with properties Id, Brand, Model, MaxSpeed, HorsePower, FuelType and a abstract method Drive(string destinationName).
2. Create other classes for JapaneseCar, GermanCar, FrenchCar, ItalianCar, AmericanCar that will inherit from the BaseEntity.
3. Make a generic database named GenericDb that will only take in classes that INHERIT FROM THE BaseEntity.
4. In the generic database create methods for Inserting a car, Get a car by id, Print all cars.
5. Create an extension method that will change the color of a text, just like we learned in class.