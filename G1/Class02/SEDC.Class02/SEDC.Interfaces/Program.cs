using SEDC.Interfaces.Entities;
using SEDC.Interfaces.Entities.Interfaces;


#region Interfaces Example 1
Pen pen = new Pen() { Type = "Pen" };
Computer computer = new Computer() { Type = "Computer" };

IThingsThatCanWriteNote phone = new Phone() { Type = "Phone" };

//pen.WriteNote();
//computer.WriteNote();
//phone.WriteNote();

CreateNote(pen);
CreateNote(computer);
CreateNote(phone);


void CreateNote(IThingsThatCanWriteNote tool)
{
    Console.WriteLine("Starting to create a note...");
    tool.WriteNote();
}
#endregion



Console.WriteLine("===============================");


#region Interfaces Example 2


IDeveloper developer = new Developer();
developer.Code();


ITester tester = new Tester();
tester.Test();

IQAEng qAEng = new QAEng();
qAEng.Code();
qAEng.Test();

qAEng.CodingAndTesting();



#endregion






