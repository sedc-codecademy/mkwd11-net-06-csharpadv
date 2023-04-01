
using SEDC.AbstractClasses.Entities;


// Cannot create an object instance from abstract classes
// Person person = new Person();


Manager manager = new Manager(1, "Martin", "Panovski", "Finance");
Manager manager1 = new Manager(2, "Antonio", "Novoselski", "IT");
manager.GetInfo();
manager1.GetInfo();


Employee emp = new Employee(1, "Monika", "Krstova", 40);
Person emp1 = new Employee(2, "Marija", "Spasova", 20);
emp.GetInfo();
emp1.GetInfo();




Circle circle = new Circle() { Radius = 10 };
Square square = new Square() { SideLength = 5 };

Console.WriteLine(circle.CalculateArea());
Console.WriteLine(square.CalculateArea());





Console.WriteLine("Finish");
