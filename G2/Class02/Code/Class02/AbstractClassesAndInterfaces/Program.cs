using AbstractClassesAndInterfaces.Entities;

//Human damjan = new Human(); WE CAN NOT INSTANCIATE AN ABSTRACT CLASS (CAN NOT CREATE OBJECTS FROM ABSTRACT CLASSES) !!!!!!!!!!!!!!!!!!!!!!!

Developer bojan = new Developer("Bojan Damchevski", 25, 123456789, new List<string> { "C#", "HTML", "CSS", "JavaScript" }, 1);

bojan.Greet("Vlade");
bojan.Code();
string infoBojan = bojan.GetInfo();
Console.WriteLine(infoBojan);

Tester krste = new Tester("Krste Krstevski", 30, 246732153, 15);

Console.WriteLine("=========================================================");

DevOps zare = new DevOps("Zarko Ilievski", 40, 34786234, true, false);

zare.Greet("Damjan");
Console.WriteLine(zare.CheckInfrastructure(200));
Console.WriteLine(zare.GetInfo());
zare.Code();