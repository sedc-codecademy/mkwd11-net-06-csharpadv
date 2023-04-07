using ExtensionMethods;

Employee employee = new Employee();
employee.FirstName = "Bob";
employee.LastName = "Bobsky";
employee.Address = "Street no.1";
employee.SetSalary(700);

//we call this method through employee instance, because it belongs to the class Employee
var salary = employee.GetSalary();


EmployeeHelper.PrintEmployee(employee);

employee.Print();


Employee secondEmployee = new Employee
{
    FirstName = "Kate",
    LastName = "Katesky",
    Address = "Kate's address"
};

secondEmployee.Print();

List<Employee> list = new List<Employee> { employee, secondEmployee };
List<int> ints = new List<int> { 4, 6, 7 };

var listInfo = list.GetInfo();
Console.WriteLine(listInfo);
var intsInfo = ints.GetInfo();
Console.WriteLine(intsInfo);


string message = "We are learning C# and it is getting complicated";

string newMEssage = message.Shorten(4);