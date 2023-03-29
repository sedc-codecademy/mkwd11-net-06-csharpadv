using SEDC.Exercises.Models;

#region Exercise 1
void WelcomeUser()
{
    Console.WriteLine("Dear user, welcome in our company!");
}

WelcomeUser();
#endregion

#region Exercise 2
void WelcomeAnyUser(string userName)
{
    Console.WriteLine($"Dear {userName}, welcome in our company!");
}
WelcomeAnyUser("Stojadin");
#endregion

#region Exercise 3
string WelcomeAnyUserAnywhere(string userName)
{
    return $"Dear {userName}, welcome in our company!";
}

Console.WriteLine(WelcomeAnyUserAnywhere("Petko"));

#endregion


#region Methods - good principles

List<int> numbersToProcess = new List<int>() { 1, 2, 3, 4, 5 };
int PrintNumbers(List<int> numbers)
{
    return numbers.Sum();
}

PrintNumbers(numbersToProcess);



Console.WriteLine("Enter firstname");
string fName = Console.ReadLine();

Console.WriteLine("Enter lastname");
string lName = Console.ReadLine();

Console.WriteLine("Enter age");
int age = int.Parse(Console.ReadLine());



Human CreateHuman(string fName, string lName, int age)
{
    Human human = new Human(fName, lName, age);
    return human;
}


CreateHuman(fName, lName, age);

#endregion



#region Exercise 4

string GetMessage(int position, string[] messages)
{
    return messages[position];
}



string[] messages = new string[] { "Hello there!", "Can you hear me?", "How are you?" };
string[] greetings = new string[] { "Hello there!", "Bye bye!", "Hello there, welcome" };

Console.WriteLine(GetMessage(1, messages));
Console.WriteLine(GetMessage(2, greetings));


double Average(List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    double average = sum / numbers.Count;
    return average;
}

double AverageShort(List<int> numbers)
{
    return numbers.Average();
}

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine(Average(numbers));
Console.WriteLine(AverageShort(numbers));



int Sum(List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}


int SumShort(List<int> numbers)
{
    return numbers.Sum();
}

Console.WriteLine(Sum(numbers));
Console.WriteLine(SumShort(numbers));



User GetUserByName(List<User> users, string name)
{
    return users.Where(user => user.Name.ToLower() == name.ToLower()).FirstOrDefault();
}

List<User> users = new List<User>()
{
    new User(1, "Martin"),
    new User(2, "Damjan"),
    new User(3, "Tosho"),
    new User(4, "Monika"),
    new User(5, "Marija"),
};

Console.WriteLine(GetUserByName(users, "Martin").Name);


User user1 = GetUserByName(users, "Tosho");
Console.WriteLine(user1.Name);


#endregion


#region Exercise 5


#endregion





