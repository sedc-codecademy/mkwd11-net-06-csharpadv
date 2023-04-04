using SEDC.Class03.Poly.Entities;

MethodPoly poly = new MethodPoly();

Console.WriteLine(poly.AddNumbers(5, 10));
Console.WriteLine(poly.AddNumbers("14", "15"));
Console.WriteLine(poly.AddNumbers(5, 10, 22));
Console.WriteLine(poly.AddNumbers(5.6, 10.4, 22.8));

poly.AddNumbers(5, 10);



Dog dog = new Dog("Bucky", "Labrador");
Cat cat = new Cat("Mobi", "Grey");

dog.Eat();
cat.Eat();
