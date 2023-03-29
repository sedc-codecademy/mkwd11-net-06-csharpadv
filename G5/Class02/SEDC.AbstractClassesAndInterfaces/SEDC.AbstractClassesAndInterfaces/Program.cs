using SEDC.AbstractClassesAndInterfaces.Domain.Intefaces;
using SEDC.AbstractClassesAndInterfaces.Domain.Models;

// Can't create an instance of an abstract class
//Human human = new Human();

// Can't create an instance of an interface
//IHuman human = new IHuman();

Developer developer1 = new Developer("Angel Mitrov",21, new List<string>() { "C#","Javascript"},1);

Console.WriteLine("===== DEVELOPER ========");
Console.WriteLine(developer1.GetInfo());
developer1.Greet("Dimitar");


Console.WriteLine("===== TESTER =====");

Tester tester = new Tester("Bob Bobski",26,true);

Console.WriteLine(tester.GetInfo());
tester.Greet("Marko");
tester.TestCode();

Console.WriteLine("===== QAEngeneer =====");

QAEngeneer QAEngeneer = new QAEngeneer("Darko Darkovic", 35, new List<string>() { "Moq", "TestApp" });

Console.WriteLine("===== Greet =====");
QAEngeneer.Greet("Lazar");
Console.WriteLine("===== Get info =====");
Console.WriteLine(QAEngeneer.GetInfo());
Console.WriteLine("===== code =====");
QAEngeneer.Code();
Console.WriteLine("===== test code =====");
QAEngeneer.TestCode();

Console.WriteLine("===== Full stack developer =====");

FullStackDeveloper fullStack = new FullStackDeveloper("Mitko",40,new List<string> { "Angular","React"}, new List<string> { "C#","C","C++","Java"});

fullStack.Greet("Dragisha");
Console.WriteLine(fullStack.GetInfo());
fullStack.Code();
fullStack.TestCode();
fullStack.DesignCode();
Console.WriteLine("==========");
fullStack.PrintFrontend();
fullStack.PrintBackend();

