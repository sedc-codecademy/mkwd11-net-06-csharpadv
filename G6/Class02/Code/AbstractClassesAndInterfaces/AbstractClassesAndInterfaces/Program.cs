using AbstractClassesAndInterfaces.Domain.Models;

//Person person = new Person(); ERROR -> abstract class
//person.GetProfessionalInfo();

Developer firstDeveloper = new Developer("Tanja S", 28, "Address 1", 6464764, "SEDC project", 7, new List<string> { "JS", "C#"});
//inherited from Person
firstDeveloper.Greet();
firstDeveloper.SendGift("flowers");
string firstDevProfessionalInfo = firstDeveloper.GetProfessionalInfo();
Console.WriteLine(firstDevProfessionalInfo);

//from interface IDeveloper
firstDeveloper.Code();
//firstDeveloper.TestingFeature(); ERROR -> Developer does not implement IQAEngineer interface

QAEngineer qaEngineer = new QAEngineer("Marko M", 30, "Address2", 784578, 3, new List<string> { "Selenium" });
//inherited from Person
qaEngineer.Greet();
qaEngineer.SendGift("bonus card");
Console.WriteLine(qaEngineer.GetProfessionalInfo());

//comes from IDeveloper interface
qaEngineer.Code();
//comes from IQAEngineer interface
qaEngineer.TestingFeature("Finance module", new DateTime(2023, 07, 01));

DevOpsEngineer devOpsEngineer = new DevOpsEngineer("Ana A.", 25, "Addres 3", 6473534, true, false);
//inherited
devOpsEngineer.Greet();
Console.WriteLine(devOpsEngineer.GetProfessionalInfo());

//comes from IDevOpsEngineer interface
Console.WriteLine(devOpsEngineer.CheckInfrastructure(500));
//comes from IDeveloper interface
devOpsEngineer.Code();


