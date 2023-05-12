using TaxiManager.Domain.Models;

var driver1 = new Driver();
driver1.FirstName = "Viktor";


var driver2 = new Driver();
driver2.FirstName = "Dragan";


var car1 = new Car();
car1.Model = "Yugo";

driver1.Car = car1;