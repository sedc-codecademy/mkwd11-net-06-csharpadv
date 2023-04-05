# Exercise from Power Point Presentation ✍

Create an interfaces called IUser, IStudent, ITeacher​

IUser : PrintUser() - Prints Id, Name and Username​

User: Id, Name, Username, Password,

IStudent: override PrintUser() to show grades​

Student: Grades

ITeacher: override PrintUser() to show subject​

Teacher: Subject

Create an abstract class User and inherits from IUser​

Create a class Student that inherits from User and IStudent​

Create a class Teacher that inherits from User and ITeacher​

Create 2 teacher and 2 student objects and call PrintUser() on all of them