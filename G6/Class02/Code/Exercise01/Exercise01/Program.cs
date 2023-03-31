using Exercise01.Domain.Models;

Teacher teacher = new Teacher(1, "John", "johnsky", "14344234", "Advanced C#");
teacher.PrintUser();
teacher.PrintSubject();

Student student = new Student(2, "Kate", "kate123", "test123", new List<int> { 6, 8, 10 });
student.PrintUser();
student.PrintGrades();
