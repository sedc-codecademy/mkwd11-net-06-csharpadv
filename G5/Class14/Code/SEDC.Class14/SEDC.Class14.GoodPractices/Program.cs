using SEDC.Class14.GoodPractices.Practices;

Service badService = new Service();
badService.GetStats();


MethodsApp methodsApp = new MethodsApp();
methodsApp.Run();


Loops loops = new Loops();

loops.BadLoop();

Console.WriteLine();

loops.GoodLoop();


IfElse ifElse = new IfElse();
Console.WriteLine("Ex. 1");
ifElse.GoodCheckIfEven(1, 10);
Console.WriteLine("Ex. 2");
ifElse.GoodCheckIfEven(10, 10);