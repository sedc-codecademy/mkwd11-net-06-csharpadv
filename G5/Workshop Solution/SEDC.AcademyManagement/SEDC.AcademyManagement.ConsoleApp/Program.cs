using SEDC.AcademyManagement.Domain;
using SEDC.AcademyManagement.Domain.Enums;
using SEDC.AcademyManagement.Domain.Models;

// Create an Academy Management app
// The app will have users that can log in and perform some actions. The user can choose one of the 3 roles and log in:

// Admin
// Trainer
// Student ( has a current Subject, and Grades )
// After logging in there should be different options for different roles:

// Admins can add/remove Teachers, Students, and other Admins ( can't remove itself )
// Trainer can choose between seeing all students and all subjects
// When choosing Students, all student names should appear
// When chosen a name of student, it should print all the subjects
// When choosing Subjects, all Subject names appear with how many students attend it next to it
// Students are shown the name of the subject that they are listening to and a list of their grades
// Try and handle all scenarios with exception handling. Handle expected exceptions with special messages.


Database database = new Database();
Console.WriteLine();
Console.WriteLine("Welcome");
Console.WriteLine();
while (true)
{
    try
    {
        Console.Write("[Login] Enter Username: ");
        string loggedInUsername = Console.ReadLine();

        if (string.IsNullOrEmpty(loggedInUsername))
        {
            throw new Exception("You must enter username");
        }

        bool isAdmin = IsAdmin(loggedInUsername);

        if (isAdmin)
        {
            // Admin Functionalities
            Console.WriteLine("1) Add trainer");
            Console.WriteLine("2) Remove trainer");
            Console.WriteLine("3) Add student");
            Console.WriteLine("4) Remove student");
            Console.WriteLine("5) Add admin");
            Console.WriteLine("6) Remove admin");
            Console.Write("Enter option > ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddMember(Role.Trainer);
                    break;
                case 2:
                    Console.Write("[Trainer] Username: ");
                    RemoveTrainer(Console.ReadLine());
                    break;
                case 3:
                    AddMember(Role.Student);
                    break;
                case 4:
                    Console.Write("[Student] Username: ");
                    RemoveStudent(Console.ReadLine());
                    break;
                case 5:
                    AddMember(Role.Admin);
                    break;
                case 6:
                    Console.Write("[Admin] Username: ");
                    RemoveAdmin(loggedInUsername, Console.ReadLine());
                    break;
                default:
                    throw new Exception("Invalid Option [1-6]");
            }
        }
        else
        {
            // Non Admin Functionalities

            // not an admin
            Trainer trainer = GetTrainer(loggedInUsername);
            if (trainer != null)
            {
                Console.WriteLine("1) List Students ");
                Console.WriteLine("2) List Subjects");
                Console.Write("Enter option > ");
                int trainerOption = int.Parse(Console.ReadLine());

                switch (trainerOption)
                {
                    case 1:
                        TrainerStudentsChoice();
                        break;
                    case 2:
                        PrintSubjects();
                        break;
                    default:
                        throw new Exception("Invalid Option [1-2]");
                }
            }
            else
            {
                // not admin & not trainer
                Student student = GetStudent(loggedInUsername);

                if (student == null)
                {
                    throw new Exception("User does not exist!");
                }

                student.PrintDetails();
            }
        }

    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR] {ex.Message}");
        Console.ResetColor();
    }



    Console.WriteLine("Press any key to exit or 'y' to continue...");
    if (Console.ReadLine().ToLower() == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}

Console.WriteLine("GoodBye :)");





// Add Method

void AddMember(Role role)
{
    Console.WriteLine("======= Adding Member =======");

    Console.Write("Username: ");
    string username = Console.ReadLine();

    if (string.IsNullOrEmpty(username))
    {
        throw new Exception("You must enter username");
    }

    bool doesUsernameExist = DoesUsernameExist(username);
    if (doesUsernameExist)
    {
        throw new Exception("User with this username already exists");
    }

    Console.Write("First Name: ");
    string firstName = Console.ReadLine();
    if (string.IsNullOrEmpty(firstName))
    {
        throw new Exception("You must enter first name");
    }

    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();

    if (string.IsNullOrEmpty(lastName))
    {
        throw new Exception("You must enter last name");
    }

    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());
    if (age < 16)
    {
        throw new Exception("Age must be greater than 16");
    }

    switch (role)
    {
        case Role.Admin:
            database.Admins.Add(new Admin(username, firstName, lastName, age));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Added new admin: {username}");
            Console.ResetColor();
            break;
        case Role.Student:
            database.Students.Add(new Student(username, firstName, lastName, age));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Added new student: {username}");
            Console.ResetColor();
            break;
        case Role.Trainer:
            database.Trainers.Add(new Trainer(username, firstName, lastName, age));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Added new trainer: {username}");
            Console.ResetColor();
            break;
        default:
            throw new Exception("Invalid Role!");
    }

}




// Remove Methods

void RemoveStudent(string username)
{
    Student student = GetStudent(username);

    if (student == null)
    {
        throw new Exception("Student with that username does not exist!");
    }
    else
    {
        database.Students.Remove(student);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Successfully deleted student {student.UserName}");
        Console.ResetColor();
    }
}

void RemoveTrainer(string username)
{
    Trainer trainer = GetTrainer(username);

    if (trainer == null)
    {
        throw new Exception("Trainer with that username does not exist!");

    }
    else
    {
        database.Trainers.Remove(trainer);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Successfully deleted trainer {trainer.UserName}");
        Console.ResetColor();
    }
}

void RemoveAdmin(string loggedInAdmin, string username)
{

    if (loggedInAdmin.ToLower() == username.ToLower())
    {
        throw new Exception("Cannot remove yourself!");
    }

    Admin admin = GetAdmin(username);

    if (admin == null)
    {
        throw new Exception("Admin with that username does not exist!");

    }
    else
    {
        database.Admins.Remove(admin);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Successfully deleted admin {admin.UserName}");
        Console.ResetColor();
    }
}



// Helper Methods
bool DoesUsernameExist(string username)
{
    Admin admin = GetAdmin(username);
    Trainer trainer = GetTrainer(username);
    Student student = GetStudent(username);

    if (admin == null && trainer == null && student == null)
    {
        return false;
    }

    return true;
}


bool IsAdmin(string username)
{
    Admin admin = GetAdmin(username);

    if (admin == null)
        return false;

    return true;
}


Admin GetAdmin(string username)
{
    return database.Admins.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());
}


Trainer GetTrainer(string username)
{
    return database.Trainers.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());
}


Student GetStudent(string username)
{
    return database.Students.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());
}


void PrintSubjects()
{
    Console.WriteLine("========== Subject List ==========");
    foreach (Subject subject in database.Subjects)
    {
        List<Student> studentAttendees = database.Students.Where(x => x.CurrentSubject != null && x.CurrentSubject.Name == subject.Name).ToList();
        Console.WriteLine($"{subject.Name}  [{studentAttendees.Count} attendances]");
    }
    Console.WriteLine("=============================");
}


void PrintStudents()
{
    Console.WriteLine("========== Student List ==========");
    foreach (Student student in database.Students)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName}");
    }
    Console.WriteLine("=============================");
}


void TrainerStudentsChoice()
{
    PrintStudents();
    Console.Write("Enter student name to see their grades: ");
    string studentName = Console.ReadLine();

    List<Student> chosenStudents = database.Students.Where(x => x.FirstName.ToLower() == studentName.ToLower()).ToList();
    if (chosenStudents.Count > 0)
    {
        chosenStudents.ForEach(x => x.PrintDetails());
    }
    else
    {
        throw new Exception("No such student found!");
    }
}