using SEDC.Class02.Exercises1.Entities;
using SEDC.Class02.Exercises1.Interfaces;

Teacher teacher1 = new Teacher(1, "Martin", "martinpano", "netigokazhuvam" , "CSharp Advanced");
ITeacher teacher2 = new Teacher(2, "Ivo", "ivo90", "netigokazhuvam123", "Node JS");


List<int> grades1 = new List<int>() { 10, 10, 10 };


IUser student1 = new Student(1, "Antonio", "antonio03", "test123", grades1);

IUser student2 = new Student(2, "Kostadin", "koki02", "kokikoki123", new List<int> { 8, 9, 10});

teacher1.PrintUser();
teacher2.PrintUser();

student1.PrintUser();
student2.PrintUser();


 