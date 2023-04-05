# Exercise from Power Point Presentation ✍

Create an interfaces called IUser, IStudent, ITeacher​

IUser : signature of PrintUser()

User: Id, Name, Username, Password, PrintUser() as abstract method

IStudent: signature of PringGrades() 

Student: Grades, override PrintUser() - to show Name, username and Average grade

ITeacher: signature of PrintSubjects 

Teacher: Subject, override PrintUser() to show Name, username and number of subjects

Create an abstract class User and inherits from IUser​

Create a class Student that inherits from User and IStudent​

Create a class Teacher that inherits from User and ITeacher​

Create 2 teacher and 2 student objects and call PrintUser() on all of them