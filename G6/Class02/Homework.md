# Homework 1
* Create interfaces called IAnimal, IDog, ICat
* IAnimal : Contains method PrintAnimal
* IDog - Contains method Bark
* ICat - Contains method Eat that gets parameter food of type string
* Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal 
* Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
* Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
* Create several objects and test the method calls

The implementation for the methods is on your choice.

# Homework 2

Car Service

1. Create one abstract class Vehicle with abstract method Drive, and two classes Car and Truck that inherit from Vehicle and override the method Drive.
2. Create 3 interfaces:
    * ICarWash that has methods WashCar that works for Cars, and WashTrailer that works for Trailers.
    * IGasPump that has method PumpGas that works for all vehicles
    * IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
3. Implement each interface in a different class: CarWash, GasPump and RepairService.
4. Implement all interfaces in one class CarCenter.
5. Methods can be implemented with Console.Writeline or changing and checking bools (ex. isClean, isGasFull, isBroken...)