using Exercise.Entities;

Developer dev1 = new Developer()
{
    FullName = "Bojan Damchevski",
    Age = 25,
    Role = (Role)1,
    DevSalary = 2000
};

Tester test1 = new Tester()
{
    FullName = "Ilija Mitev",
    Age = 27,
    Role = (Role)2
};

dev1.PrintInfo();
Console.WriteLine(dev1.Code());
test1.Test(5);