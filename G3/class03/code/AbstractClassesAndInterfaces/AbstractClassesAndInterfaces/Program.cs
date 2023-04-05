using AbstractClassesAndInterfaces.Entities.Classes;

Developer dev = new Developer("Bob Bobsky", 44, 38970070070, 
    new List<string> { "C#", "JavaScript", "TypeScript" }, 6);

Tester tester = new Tester("Jill Wayne", 32, 38971071071, 560);

Operations ops = new Operations("Greg Gregsky", 28, 38975075075, 
    new List<string> { "Optimus", "ProtoBeat", "PickPro" });

DevOps devOps = new DevOps("Anne Brown", 24, 38977070070, true, false);

QAEngineer qa = new QAEngineer("Mia Wong", 34, 38972072072,
    new List<string>() { "Selenium" });


Console.WriteLine("The Developer");
Console.WriteLine(dev.GetInfo());
dev.Greet("Students");
dev.Code();
Console.WriteLine("----------------");
Console.WriteLine("The Tester:");
Console.WriteLine(tester.GetInfo());
tester.Greet("Students");
tester.TestFeature("Log In");
Console.WriteLine("----------------");
Console.WriteLine("The IT Operations Specialist:");
Console.WriteLine(ops.GetInfo());
ops.Greet("Students");
Console.WriteLine($"Infrastructure OK: {ops.CheckInfrastructure(200)}");
Console.WriteLine("----------------");
Console.WriteLine("The DevOps:");
Console.WriteLine(devOps.GetInfo());
devOps.Greet("Students");
devOps.Code();
Console.WriteLine($"Infrastructure OK: {ops.CheckInfrastructure(200)}");
Console.WriteLine("----------------");
Console.WriteLine("The QA Engineer:");
Console.WriteLine(qa.GetInfo());
qa.Greet("Students");
qa.Code();
qa.TestFeature("Order");
Console.WriteLine("----------------");
Console.ReadLine();