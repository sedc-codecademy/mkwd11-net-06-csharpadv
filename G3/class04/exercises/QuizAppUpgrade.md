# QuizzApp upgrade ✍

1. Copy the code from QuizApp in separate location.

2. Create Abstraction for both Quiz and User services by creating appropriate interfaces and implement them on both classes. Interfaces should be placed inside QuizApp.Domain project under Abstraction Folder.

3. Create a class called AppMain under QuizApp project with a public void method called Run().

4. Create two private readonly fileds in AppMain class for the needed services but their type will be interface instead of a class.

5. Give the needed implementation of those interfaces in AppMain class constructor as input parameters.

6. Transfer all the needed code from Program.cs class inside Run() void method and try to use the already created private fileds.

7. In Program.cs create new instance of AppMain class with the needed parameters in the constructor, and call the run method. The business logic of the application shoud stay the same. 